namespace MunicipalServicesApp
{
    partial class LocalEventsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstEvents;
        private System.Windows.Forms.ListBox lstRecommendations; // Added for recommendations
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblRecommendations; // Added label for recommendations
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.TextBox txtNewEventName; // New event name input
        private System.Windows.Forms.DateTimePicker dtpNewEventDate; // New event date picker
        private System.Windows.Forms.ComboBox cmbNewEventCategory; // New event category input
        private System.Windows.Forms.Label lblNewEventName; // New event name label
        private System.Windows.Forms.Label lblNewEventDate; // New event date label
        private System.Windows.Forms.Label lblNewEventCategory; // New event category label
        private System.Windows.Forms.Button btnAddEvent; // Button to add a new event
        private System.Windows.Forms.Button btnBackToMainMenu; // Declare the back button


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
            this.lstEvents = new System.Windows.Forms.ListBox();
            this.lstRecommendations = new System.Windows.Forms.ListBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblRecommendations = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.txtNewEventName = new System.Windows.Forms.TextBox();
            this.dtpNewEventDate = new System.Windows.Forms.DateTimePicker();
            this.cmbNewEventCategory = new System.Windows.Forms.ComboBox();
            this.lblNewEventName = new System.Windows.Forms.Label();
            this.lblNewEventDate = new System.Windows.Forms.Label();
            this.lblNewEventCategory = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.btnBackToMainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstEvents
            // 
            this.lstEvents.FormattingEnabled = true;
            this.lstEvents.Location = new System.Drawing.Point(12, 12);
            this.lstEvents.Name = "lstEvents";
            this.lstEvents.Size = new System.Drawing.Size(776, 290);
            this.lstEvents.TabIndex = 0;
            this.lstEvents.SelectedIndexChanged += new System.EventHandler(this.lstEvents_SelectedIndexChanged);
            // 
            // lstRecommendations
            // 
            this.lstRecommendations.FormattingEnabled = true;
            this.lstRecommendations.Location = new System.Drawing.Point(12, 450);
            this.lstRecommendations.Name = "lstRecommendations";
            this.lstRecommendations.Size = new System.Drawing.Size(776, 95);
            this.lstRecommendations.TabIndex = 7;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Festivals",
            "Government",
            "Markets",
            "Entertainment",
            "Sports",
            "Other"});
            this.cmbCategory.Location = new System.Drawing.Point(12, 340);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbCategory.TabIndex = 1;
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(230, 340);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEventDate.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblCategory.Location = new System.Drawing.Point(12, 317);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(57, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category:";
            this.lblCategory.Click += new System.EventHandler(this.lblCategory_Click);
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblEventDate.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblEventDate.Location = new System.Drawing.Point(227, 317);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(66, 13);
            this.lblEventDate.TabIndex = 4;
            this.lblEventDate.Text = "Event Date:";
            // 
            // lblRecommendations
            // 
            this.lblRecommendations.AutoSize = true;
            this.lblRecommendations.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblRecommendations.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblRecommendations.Location = new System.Drawing.Point(12, 430);
            this.lblRecommendations.Name = "lblRecommendations";
            this.lblRecommendations.Size = new System.Drawing.Size(107, 13);
            this.lblRecommendations.TabIndex = 8;
            this.lblRecommendations.Text = "Recommendations:";
            this.lblRecommendations.Click += new System.EventHandler(this.lblRecommendations_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(450, 336);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClearSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClearSearch.Location = new System.Drawing.Point(556, 336);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(100, 30);
            this.btnClearSearch.TabIndex = 6;
            this.btnClearSearch.Text = "Clear Search";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtNewEventName
            // 
            this.txtNewEventName.Location = new System.Drawing.Point(12, 400);
            this.txtNewEventName.Name = "txtNewEventName";
            this.txtNewEventName.Size = new System.Drawing.Size(200, 20);
            this.txtNewEventName.TabIndex = 9;
            // 
            // dtpNewEventDate
            // 
            this.dtpNewEventDate.Location = new System.Drawing.Point(230, 400);
            this.dtpNewEventDate.Name = "dtpNewEventDate";
            this.dtpNewEventDate.Size = new System.Drawing.Size(200, 20);
            this.dtpNewEventDate.TabIndex = 10;
            // 
            // cmbNewEventCategory
            // 
            this.cmbNewEventCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewEventCategory.FormattingEnabled = true;
            this.cmbNewEventCategory.Items.AddRange(new object[] {
            "Festivals",
            "Government",
            "Markets",
            "Entertainment",
            "Sports",
            "Other"});
            this.cmbNewEventCategory.Location = new System.Drawing.Point(450, 400);
            this.cmbNewEventCategory.Name = "cmbNewEventCategory";
            this.cmbNewEventCategory.Size = new System.Drawing.Size(200, 21);
            this.cmbNewEventCategory.TabIndex = 11;
            // 
            // lblNewEventName
            // 
            this.lblNewEventName.AutoSize = true;
            this.lblNewEventName.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblNewEventName.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblNewEventName.Location = new System.Drawing.Point(12, 380);
            this.lblNewEventName.Name = "lblNewEventName";
            this.lblNewEventName.Size = new System.Drawing.Size(100, 13);
            this.lblNewEventName.TabIndex = 12;
            this.lblNewEventName.Text = "New Event Name:";
            // 
            // lblNewEventDate
            // 
            this.lblNewEventDate.AutoSize = true;
            this.lblNewEventDate.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblNewEventDate.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblNewEventDate.Location = new System.Drawing.Point(227, 380);
            this.lblNewEventDate.Name = "lblNewEventDate";
            this.lblNewEventDate.Size = new System.Drawing.Size(93, 13);
            this.lblNewEventDate.TabIndex = 13;
            this.lblNewEventDate.Text = "New Event Date:";
            // 
            // lblNewEventCategory
            // 
            this.lblNewEventCategory.AutoSize = true;
            this.lblNewEventCategory.Font = new System.Drawing.Font("Segoe UI", 8.2F, System.Drawing.FontStyle.Bold);
            this.lblNewEventCategory.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__4_;
            this.lblNewEventCategory.Location = new System.Drawing.Point(447, 380);
            this.lblNewEventCategory.Name = "lblNewEventCategory";
            this.lblNewEventCategory.Size = new System.Drawing.Size(116, 13);
            this.lblNewEventCategory.TabIndex = 14;
            this.lblNewEventCategory.Text = "New Event Category:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddEvent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddEvent.Location = new System.Drawing.Point(670, 396);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(100, 30);
            this.btnAddEvent.TabIndex = 15;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = false;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnBackToMainMenu
            // 
            this.btnBackToMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBackToMainMenu.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.images;
            this.btnBackToMainMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnBackToMainMenu.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__2_;
            this.btnBackToMainMenu.Location = new System.Drawing.Point(609, 556);
            this.btnBackToMainMenu.Name = "btnBackToMainMenu";
            this.btnBackToMainMenu.Size = new System.Drawing.Size(179, 30);
            this.btnBackToMainMenu.TabIndex = 16;
            this.btnBackToMainMenu.Text = "Back to Main Menu";
            this.btnBackToMainMenu.UseVisualStyleBackColor = false;
            this.btnBackToMainMenu.Click += new System.EventHandler(this.btnBackToMainMenu_Click);
            // 
            // LocalEventsForm
            // 
            this.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.lblNewEventCategory);
            this.Controls.Add(this.lblNewEventDate);
            this.Controls.Add(this.lblNewEventName);
            this.Controls.Add(this.cmbNewEventCategory);
            this.Controls.Add(this.dtpNewEventDate);
            this.Controls.Add(this.txtNewEventName);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblRecommendations);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lstRecommendations);
            this.Controls.Add(this.lstEvents);
            this.Controls.Add(this.btnBackToMainMenu);
            this.Name = "LocalEventsForm";
            this.Text = "Local Events and Announcements";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
