using MunicipalServiceApp;
using System;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Event handler for the "Report Issues" button
        private void btnReportIssues_Click(object sender, EventArgs e)
        {
            // Opens the ReportIssuesForm and hides the current form (Form1)
            ReportIssuesForm reportIssuesForm = new ReportIssuesForm();
            reportIssuesForm.Show();
            this.Hide();
        }

        // Event handler for the "Local Events and Announcements" button
        private void btnLocalEventsAndAnnouncements_Click(object sender, EventArgs e)
        {
            // Opens the LocalEventsForm and hides the current form (Form1)
            LocalEventsForm localEventsForm = new LocalEventsForm();
            localEventsForm.Show();
            this.Hide();
        }

        // Event handler for the "Service Request Status" button
        private void btnServiceRequestStatus_Click(object sender, EventArgs e)
        {
            // Open the ServiceRequestStatusForm when the button is clicked
            ServiceRequestStatusForm serviceRequestStatusForm = new ServiceRequestStatusForm();
            serviceRequestStatusForm.ShowDialog();
        }


        // Optional method for form load, no additional code needed right now
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
