using System;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    partial class ServiceRequestStatusForm
    {
        
        private System.ComponentModel.IContainer components = null;

        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.listBoxRequests = new System.Windows.Forms.ListBox();
            this.txtRequestId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxRequests
            // 
            this.listBoxRequests.FormattingEnabled = true;
            this.listBoxRequests.Location = new System.Drawing.Point(30, 30);
            this.listBoxRequests.Name = "listBoxRequests";
            this.listBoxRequests.Size = new System.Drawing.Size(350, 147);
            this.listBoxRequests.TabIndex = 0;
            // 
            // txtRequestId
            // 
            this.txtRequestId.Location = new System.Drawing.Point(30, 200);
            this.txtRequestId.Name = "txtRequestId";
            this.txtRequestId.Size = new System.Drawing.Size(200, 20);
            this.txtRequestId.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story;
            this.btnSearch.Location = new System.Drawing.Point(250, 200);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 29);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Wheat;
            this.lblStatus.Location = new System.Drawing.Point(30, 240);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(63, 13);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status: N/A";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.Wheat;
            this.lblDescription.Location = new System.Drawing.Point(30, 270);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(86, 13);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description: N/A";
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnClose.Image = global::MunicipalServicesApp.Properties.Resources.Cream_and_Brown_Minimalist_Watercolor_Background_Instagram_Story__2_;
            this.btnClose.Location = new System.Drawing.Point(250, 300);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ServiceRequestStatusForm
            // 
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = global::MunicipalServicesApp.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtRequestId);
            this.Controls.Add(this.listBoxRequests);
            this.Name = "ServiceRequestStatusForm";
            this.Text = "Service Request Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRequests;
        private System.Windows.Forms.TextBox txtRequestId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnClose;
    }
}
