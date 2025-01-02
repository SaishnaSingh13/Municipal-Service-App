namespace MunicipalServicesApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnReportIssues;
        private System.Windows.Forms.Button btnLocalEventsAndAnnouncements;
        private System.Windows.Forms.Button btnServiceRequestStatus;
        private System.Windows.Forms.Label lblTitle;

        // Dispose method to clean up any resources being used.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnReportIssues = new System.Windows.Forms.Button();
            this.btnLocalEventsAndAnnouncements = new System.Windows.Forms.Button();
            this.btnServiceRequestStatus = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReportIssues
            // 
            this.btnReportIssues.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReportIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReportIssues.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnReportIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnReportIssues.ForeColor = System.Drawing.Color.Black;
            this.btnReportIssues.Location = new System.Drawing.Point(142, 59);
            this.btnReportIssues.Name = "btnReportIssues";
            this.btnReportIssues.Size = new System.Drawing.Size(250, 76);
            this.btnReportIssues.TabIndex = 0;
            this.btnReportIssues.Text = "Report Issues";
            this.btnReportIssues.UseVisualStyleBackColor = false;
            this.btnReportIssues.Click += new System.EventHandler(this.btnReportIssues_Click);
            // 
            // btnLocalEventsAndAnnouncements
            // 
            this.btnLocalEventsAndAnnouncements.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLocalEventsAndAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLocalEventsAndAnnouncements.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnLocalEventsAndAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLocalEventsAndAnnouncements.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnLocalEventsAndAnnouncements.ForeColor = System.Drawing.Color.Black;
            this.btnLocalEventsAndAnnouncements.Location = new System.Drawing.Point(142, 151);
            this.btnLocalEventsAndAnnouncements.Name = "btnLocalEventsAndAnnouncements";
            this.btnLocalEventsAndAnnouncements.Size = new System.Drawing.Size(250, 100);
            this.btnLocalEventsAndAnnouncements.TabIndex = 1;
            this.btnLocalEventsAndAnnouncements.Text = "Local Events and Announcements";
            this.btnLocalEventsAndAnnouncements.UseVisualStyleBackColor = false;
            this.btnLocalEventsAndAnnouncements.Click += new System.EventHandler(this.btnLocalEventsAndAnnouncements_Click);
            // 
            // btnServiceRequestStatus
            // 
            this.btnServiceRequestStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnServiceRequestStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnServiceRequestStatus.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.btnServiceRequestStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServiceRequestStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnServiceRequestStatus.ForeColor = System.Drawing.Color.Black;
            this.btnServiceRequestStatus.Location = new System.Drawing.Point(142, 267);
            this.btnServiceRequestStatus.Name = "btnServiceRequestStatus";
            this.btnServiceRequestStatus.Size = new System.Drawing.Size(250, 94);
            this.btnServiceRequestStatus.TabIndex = 2;
            this.btnServiceRequestStatus.Text = "Service Request Status";
            this.btnServiceRequestStatus.UseVisualStyleBackColor = false;
            this.btnServiceRequestStatus.Click += new System.EventHandler(this.btnServiceRequestStatus_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__1_;
            this.lblTitle.Location = new System.Drawing.Point(153, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(229, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Municipality Application";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(541, 373);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnServiceRequestStatus);
            this.Controls.Add(this.btnLocalEventsAndAnnouncements);
            this.Controls.Add(this.btnReportIssues);
            this.Name = "Form1";
            this.Text = "Municipal Services";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
