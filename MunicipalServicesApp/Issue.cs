using System.Collections.Generic;

namespace MunicipalServicesApp
{
    // The Issue class represents a reported issue in the municipal services application.
    public class Issue
    {
        // Properties for storing details of the reported issue

        // Location of the issue (e.g., street address, area name)
        public string Location { get; set; }

        // Category of the issue (e.g., "Road Damage", "Water Leakage")
        public string Category { get; set; }

        // Detailed description of the issue provided by the user
        public string Description { get; set; }

        // File path to any media (e.g., photos or videos) associated with the issue
        public string MediaFilePath { get; set; }

        // Optional feedback provided by the user after reporting the issue
        public string Feedback { get; set; }

        // Optional rating provided by the user about the issue handling or resolution
        public int Rating { get; set; }


        // List to store issues
        public static List<Issue> IssuesList { get; set; } = new List<Issue>();

        //Constructor to initialize a new instance of the Issue class
        // Parameters:
        // location - Location of the issue
        // category - Category of the issue
        // description - Detailed description of the issue
        // mediaFilePath - (Optional) Path to any associated media file
        // feedback - (Optional) User feedback after reporting the issue
        // rating - (Optional) User rating for issue handling/resolution
        public Issue(string location, string category, string description, string mediaFilePath = null, string feedback = null, int rating = 0)
        {
            // Initialize properties with the provided values
            Location = location;
            Category = category;
            Description = description;
            MediaFilePath = mediaFilePath;
            Feedback = feedback;
            Rating = rating;

            // Add the issue to the list
            IssuesList.Add(this);
        }
    }
}
