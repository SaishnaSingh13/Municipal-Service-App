namespace MunicipalServicesApp
{
    // Partial class definition for the ReportIssuesForm, which allows users to report municipal issues.
    partial class ReportIssuesForm
    {
        // Required designer variable to manage resources.
        private System.ComponentModel.IContainer components = null;

        // Method to initialize the form components and UI elements.
        private void InitializeComponent()
        {
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.rtbDescription = new System.Windows.Forms.RichTextBox();
            this.btnAttachMedia = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEngagement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLocation.Location = new System.Drawing.Point(12, 40);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(360, 25);
            this.txtLocation.TabIndex = 0;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Sanitation",
            "Roads",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(12, 100);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(360, 25);
            this.cmbCategory.TabIndex = 1;
            // 
            // rtbDescription
            // 
            this.rtbDescription.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbDescription.Location = new System.Drawing.Point(12, 160);
            this.rtbDescription.Name = "rtbDescription";
            this.rtbDescription.Size = new System.Drawing.Size(360, 120);
            this.rtbDescription.TabIndex = 2;
            this.rtbDescription.Text = "";
            this.rtbDescription.TextChanged += new System.EventHandler(this.rtbDescription_TextChanged);
            // 
            // btnAttachMedia
            // 
            this.btnAttachMedia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnAttachMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttachMedia.Font = new System.Drawing.Font("Impact", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttachMedia.ForeColor = System.Drawing.Color.Black;
            this.btnAttachMedia.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnAttachMedia.Location = new System.Drawing.Point(12, 300);
            this.btnAttachMedia.Name = "btnAttachMedia";
            this.btnAttachMedia.Size = new System.Drawing.Size(107, 35);
            this.btnAttachMedia.TabIndex = 3;
            this.btnAttachMedia.Text = "Attach Media";
            this.btnAttachMedia.UseVisualStyleBackColor = false;
            this.btnAttachMedia.Click += new System.EventHandler(this.btnAttachMedia_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btnSubmit.ForeColor = System.Drawing.Color.Black;
            this.btnSubmit.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnSubmit.Location = new System.Drawing.Point(138, 300);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 35);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Impact", 9.75F);
            this.btnBackToMainMenu.ForeColor = System.Drawing.Color.Black;
            this.btnBackToMainMenu.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(263, 300);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(109, 35);
            this.btnBackToMainMenu.TabIndex = 5;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Sylfaen", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblLocation.Location = new System.Drawing.Point(12, 20);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(67, 18);
            this.lblLocation.TabIndex = 7;
            this.lblLocation.Text = "Location:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Sylfaen", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblCategory.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblCategory.Location = new System.Drawing.Point(12, 80);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(69, 18);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Sylfaen", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblDescription.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblDescription.Location = new System.Drawing.Point(12, 140);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(84, 18);
            this.lblDescription.TabIndex = 9;
            this.lblDescription.Text = "Description:";
            // 
            // lblEngagement
            // 
            this.lblEngagement.AutoSize = true;
            this.lblEngagement.BackColor = System.Drawing.Color.White;
            this.lblEngagement.Font = new System.Drawing.Font("Sitka Subheading", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEngagement.ForeColor = System.Drawing.Color.Black;
            this.lblEngagement.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblEngagement.Location = new System.Drawing.Point(95, 353);
            this.lblEngagement.Name = "lblEngagement";
            this.lblEngagement.Size = new System.Drawing.Size(186, 19);
            this.lblEngagement.TabIndex = 6;
            this.lblEngagement.Text = "Thank you for your feedback!";
            this.lblEngagement.Visible = false;
            this.lblEngagement.Click += new System.EventHandler(this.lblEngagement_Click);
            // 
            // ReportIssuesForm
            // 
            this.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(394, 381);
            this.Controls.Add(this.lblEngagement);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnAttachMedia);
            this.Controls.Add(this.rtbDescription);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblDescription);
            this.Name = "ReportIssuesForm";
            this.Text = "Report Issues";
            this.Load += new System.EventHandler(this.ReportIssuesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Form controls declarations
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.Button btnAttachMedia;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBackToMainMenu;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblEngagement;
    }
}
