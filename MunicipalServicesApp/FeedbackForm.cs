using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class FeedbackForm : Form
    {
        private Issue _issue;

        // Constructor to initialize the form with the specified issue
        public FeedbackForm(Issue issue)
        {
            InitializeComponent();
            _issue = issue;
        }

        // Event handler for the Submit Feedback button click event
        private void btnSubmitFeedback_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtbFeedback.Text) || cmbRating.SelectedIndex == -1)
            {
                MessageBox.Show("Please provide feedback and a rating.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update the issue object with the feedback text and rating
            _issue.Feedback = rtbFeedback.Text;
            _issue.Rating = int.Parse(cmbRating.SelectedItem.ToString());

            MessageBox.Show("Thank you for your feedback!", "Feedback Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {

        }

        // Method to retrieve an issue from the list based on the given location
        public static Issue GetIssueByLocation(string location)
        {
            // Retrieve the issue from the list based on location
            foreach (var issue in Issue.IssuesList)
            {
                if (issue.Location == location)
                {
                    return issue;
                }
            }
            return null;
        }
    }
}
