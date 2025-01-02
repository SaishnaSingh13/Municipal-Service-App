using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MunicipalServicesApp
{

    public partial class LocalEventsForm : Form
    {
        // Using advanced data structures to store events
        private SortedDictionary<DateTime, Queue<string>> eventQueue; 
        private Dictionary<string, HashSet<string>> categoryEvents; 

        // For recommendation feature
        private Dictionary<string, int> userSearchPreferences; 
        private Queue<DateTime> recentSearchDates; 

        public LocalEventsForm()
        {
            InitializeComponent();

            // Initialize the data structures
            eventQueue = new SortedDictionary<DateTime, Queue<string>>();
            categoryEvents = new Dictionary<string, HashSet<string>>();
            userSearchPreferences = new Dictionary<string, int>();
            recentSearchDates = new Queue<DateTime>();

            // Load some sample events
            LoadSampleEvents();
            DisplayEvents();
        }

        private void LoadSampleEvents()
        {
            // Add sample events with dates and categories
            AddEvent("Annual Community Festival", new DateTime(2024, 12, 25), "Festivals");
            AddEvent("Town Hall Meeting", new DateTime(2024, 10, 20), "Government");
            AddEvent("Local Farmer's Market", new DateTime(2024, 11, 15), "Markets");
            AddEvent("Music Concert", new DateTime(2024, 12, 1), "Entertainment");
        }

        private void AddEvent(string eventName, DateTime eventDate, string category)
        {
            // Add the event to the queue based on date
            if (!eventQueue.ContainsKey(eventDate))
            {
                eventQueue[eventDate] = new Queue<string>();
            }
            eventQueue[eventDate].Enqueue(eventName);

            // Add the event to the category-based set
            if (!categoryEvents.ContainsKey(category))
            {
                categoryEvents[category] = new HashSet<string>();
            }
            categoryEvents[category].Add(eventName);

            // Update the event display
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            // Display events sorted by date
            lstEvents.Items.Clear();
            foreach (var eventDate in eventQueue)
            {
                foreach (var eventName in eventDate.Value)
                {
                    lstEvents.Items.Add($"{eventDate.Key.ToShortDateString()} - {eventName}");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCategory = cmbCategory.SelectedItem?.ToString();
            DateTime searchDate = dtpEventDate.Value.Date;

            lstEvents.Items.Clear();

            // Search by category if selected
            if (!string.IsNullOrEmpty(searchCategory) && categoryEvents.ContainsKey(searchCategory))
            {
                foreach (var eventName in categoryEvents[searchCategory])
                {
                    lstEvents.Items.Add($"Category: {searchCategory} - {eventName}");
                }

                // Track the user's category search preference
                if (userSearchPreferences.ContainsKey(searchCategory))
                {
                    userSearchPreferences[searchCategory]++;
                }
                else
                {
                    userSearchPreferences[searchCategory] = 1;
                }
            }
            // Search by date if selected
            else if (eventQueue.ContainsKey(searchDate))
            {
                foreach (var eventName in eventQueue[searchDate])
                {
                    lstEvents.Items.Add($"{searchDate.ToShortDateString()} - {eventName}");
                }

                // Track the user's recent search dates
                if (recentSearchDates.Count >= 5) 
                {
                    recentSearchDates.Dequeue();
                }
                recentSearchDates.Enqueue(searchDate);
            }
            else
            {
                lstEvents.Items.Add("No events found for the selected criteria.");
            }

            // After a search, generate recommendations
            GenerateRecommendations();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            string newEventName = txtNewEventName.Text;
            DateTime newEventDate = dtpNewEventDate.Value;
            string newEventCategory = cmbNewEventCategory.SelectedItem?.ToString();

            // Validate event details
            if (string.IsNullOrEmpty(newEventName) || string.IsNullOrEmpty(newEventCategory))
            {
                MessageBox.Show("Please fill in all event details.");
                return;
            }
            if (newEventDate.Date < DateTime.Now.Date)
            {
                MessageBox.Show("Event date cannot be in the past.");
                return;
            }

            AddEvent(newEventName, newEventDate, newEventCategory);
            MessageBox.Show("Event added successfully!");
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            cmbCategory.SelectedIndex = -1;
            dtpEventDate.Value = DateTime.Now;
            DisplayEvents(); // Reload all events
        }

        private void GenerateRecommendations()
        {
            lstRecommendations.Items.Clear();

            // Recommend events from the most searched category
            var topCategory = userSearchPreferences
                                .OrderByDescending(c => c.Value)
                                .FirstOrDefault().Key;

            if (!string.IsNullOrEmpty(topCategory) && categoryEvents.ContainsKey(topCategory))
            {
                lstRecommendations.Items.Add($"Based on your interest in {topCategory}:");
                foreach (var eventName in categoryEvents[topCategory].Take(3)) // Show 3 recommendations
                {
                    lstRecommendations.Items.Add(eventName);
                }
            }

            // Recommend events based on recently searched dates
            if (recentSearchDates.Count > 0)
            {
                var topDate = recentSearchDates.GroupBy(d => d)
                                .OrderByDescending(g => g.Count())
                                .FirstOrDefault()?.Key;

                if (topDate != null && eventQueue.ContainsKey(topDate.Value))
                {
                    lstRecommendations.Items.Add($"Events on or near {topDate.Value.ToShortDateString()}:");
                    foreach (var eventName in eventQueue[topDate.Value].Take(3)) 
                    {
                        lstRecommendations.Items.Add(eventName);
                    }
                }
            }

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            Form1 mainMenu = new Form1(); // Create an instance of Form1
            mainMenu.Show(); // Show the main menu
            this.Close(); // Close the LocalEventsForm 
        }

        private void lblRecommendations_Click(object sender, EventArgs e)
        {

        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
