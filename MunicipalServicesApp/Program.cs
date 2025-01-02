using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    // The Program class is the entry point of the Municipal Services application.
    internal static class Program
    {
        // Global list to store issues
        public static List<Issue> Issues = new List<Issue>();
        // The Main method is the starting point of the application.
        // It initializes the application and opens the main form (Form1).
        // Indicates that the COM threading model for the application is single-threaded apartment (STA)
        [STAThread]
        static void Main()
        {
            // Enables visual styles for the application, making the form controls look modern
            Application.EnableVisualStyles();

            // Sets the default text rendering to be compatible with GDI+ text rendering
            Application.SetCompatibleTextRenderingDefault(false);

            // Starts the application with the main menu form (Form1)
            Application.Run(new Form1()); 
        }
    }
}
