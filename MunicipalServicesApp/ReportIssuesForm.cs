using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssuesForm : Form
    {
        // Static list to store reported issues
        public static List<Issue> IssuesList = new List<Issue>();

        private string selectedMediaFilePath;

        public ReportIssuesForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text) || cmbCategory.SelectedIndex == -1 || string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Please fill out all fields before submitting.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new issue instance and add it to the list
            Issue newIssue = new Issue(txtLocation.Text, cmbCategory.SelectedItem.ToString(), rtbDescription.Text, selectedMediaFilePath);
            IssuesList.Add(newIssue);

            MessageBox.Show("Issue reported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lblEngagement.Visible = true; // Show engagement message

            // Open the feedback form
            FeedbackForm feedbackForm = new FeedbackForm(newIssue);
            feedbackForm.ShowDialog();
        }


        private void btnAttachMedia_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg; *.jpeg; *.png)|*.jpg;*.jpeg;*.png|Document files (*.pdf; *.doc; *.docx)|*.pdf;*.doc;*.docx";
                openFileDialog.Title = "Select Media File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    selectedMediaFilePath = openFileDialog.FileName;
                    MessageBox.Show($"Selected file: {openFileDialog.FileName}", "File Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 mainMenu = new Form1();
            mainMenu.Show();
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            // This is where you can handle the event when the text in the RichTextBox changes.
        }

        private void lblEngagement_Click(object sender, EventArgs e)
        {
            // This method will handle the click event of the lblEngagement label.
        }

        private void ReportIssuesForm_Load(object sender, EventArgs e)
        {

        }
    }

}
