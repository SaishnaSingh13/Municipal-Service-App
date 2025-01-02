namespace MunicipalServicesApp
{
    // Partial class definition for FeedbackForm, handling user feedback submission
    partial class FeedbackForm
    {
        // Private member variables for form components
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnSubmitFeedback;

        // Dispose method to clean up any resources being used
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                // Dispose of the components if disposing is true
                components.Dispose();
            }
            // Call base class Dispose method
            base.Dispose(disposing);
        }

        // Method to initialize form components
        private void InitializeComponent()
        {
            this.lblFeedback = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSubmitFeedback = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Sylfaen", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblFeedback.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblFeedback.Location = new System.Drawing.Point(12, 9);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(72, 18);
            this.lblFeedback.TabIndex = 0;
            this.lblFeedback.Text = "Feedback:";
            this.lblFeedback.Click += new System.EventHandler(this.lblFeedback_Click);
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Sylfaen", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblRating.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblRating.Location = new System.Drawing.Point(12, 145);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(52, 18);
            this.lblRating.TabIndex = 1;
            this.lblRating.Text = "Rating:";
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbFeedback.Location = new System.Drawing.Point(12, 35);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.Size = new System.Drawing.Size(360, 100);
            this.rtbFeedback.TabIndex = 2;
            this.rtbFeedback.Text = "";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbRating.Location = new System.Drawing.Point(12, 171);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(360, 25);
            this.cmbRating.TabIndex = 3;
            // 
            // btnSubmitFeedback
            // 
            this.btnSubmitFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSubmitFeedback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitFeedback.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btnSubmitFeedback.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitFeedback.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnSubmitFeedback.Location = new System.Drawing.Point(138, 220);
            this.btnSubmitFeedback.Name = "btnSubmitFeedback";
            this.btnSubmitFeedback.Size = new System.Drawing.Size(100, 35);
            this.btnSubmitFeedback.TabIndex = 4;
            this.btnSubmitFeedback.Text = "Submit";
            this.btnSubmitFeedback.UseVisualStyleBackColor = false;
            this.btnSubmitFeedback.Click += new System.EventHandler(this.btnSubmitFeedback_Click);
            // 
            // FeedbackForm
            // 
            this.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.btnSubmitFeedback);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.rtbFeedback);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblFeedback);
            this.Name = "FeedbackForm";
            this.Text = "Submit Feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
