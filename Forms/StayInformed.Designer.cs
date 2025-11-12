using System.Drawing;
using System.Windows.Forms;

namespace TableValleyMunicipalApp.Forms
{
    partial class StayInformed
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpAddEvent;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAddevent;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flpEvents;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.Label lblSort;

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
            this.grpAddEvent = new System.Windows.Forms.GroupBox();
            this.lblEventName = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAddevent = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.flpEvents = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grpAddEvent.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddEvent
            // 
            this.grpAddEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.grpAddEvent.Controls.Add(this.lblEventName);
            this.grpAddEvent.Controls.Add(this.txtEventName);
            this.grpAddEvent.Controls.Add(this.lblDate);
            this.grpAddEvent.Controls.Add(this.dtpEventDate);
            this.grpAddEvent.Controls.Add(this.lblCategory);
            this.grpAddEvent.Controls.Add(this.cmbCategory);
            this.grpAddEvent.Controls.Add(this.lblLocation);
            this.grpAddEvent.Controls.Add(this.txtLocation);
            this.grpAddEvent.Controls.Add(this.lblDescription);
            this.grpAddEvent.Controls.Add(this.txtDescription);
            this.grpAddEvent.Controls.Add(this.btnAddevent);
            this.grpAddEvent.Controls.Add(this.btnBack);
            this.grpAddEvent.Location = new System.Drawing.Point(12, 12);
            this.grpAddEvent.Name = "grpAddEvent";
            this.grpAddEvent.Size = new System.Drawing.Size(560, 310);
            this.grpAddEvent.TabIndex = 0;
            this.grpAddEvent.TabStop = false;
            this.grpAddEvent.Text = "Add any Local Event";
            // 
            // lblEventName
            // 
            this.lblEventName.Location = new System.Drawing.Point(20, 50);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(80, 20);
            this.lblEventName.TabIndex = 0;
            this.lblEventName.Text = "Enter Event Name:";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(110, 47);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(200, 20);
            this.txtEventName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Location = new System.Drawing.Point(20, 58);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date:";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(110, 82);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEventDate.TabIndex = 3;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(20, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 23);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
            "Environment",
            "Community",
            "Sports",
            "Education",
            "Safety",
            "Utilities"});
            this.cmbCategory.Location = new System.Drawing.Point(110, 117);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 21);
            this.cmbCategory.TabIndex = 5;
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(20, 155);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(80, 23);
            this.lblLocation.TabIndex = 6;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(110, 152);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(200, 20);
            this.txtLocation.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 23);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(110, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(420, 55);
            this.txtDescription.TabIndex = 9;
            // 
            // btnAddevent
            // 
            this.btnAddevent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(144)))));
            this.btnAddevent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddevent.ForeColor = System.Drawing.Color.White;
            this.btnAddevent.Location = new System.Drawing.Point(450, 265);
            this.btnAddevent.Name = "btnAddevent";
            this.btnAddevent.Size = new System.Drawing.Size(80, 25);
            this.btnAddevent.TabIndex = 10;
            this.btnAddevent.Text = "Add Event";
            this.btnAddevent.UseVisualStyleBackColor = false;
            this.btnAddevent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(144)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(6, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flpEvents
            // 
            this.flpEvents.AutoScroll = true;
            this.flpEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.flpEvents.Location = new System.Drawing.Point(12, 370);
            this.flpEvents.Name = "flpEvents";
            this.flpEvents.Size = new System.Drawing.Size(560, 170);
            this.flpEvents.TabIndex = 4;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(12, 335);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search all events...";
            // 
            // cmbSort
            // 
            this.cmbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSort.Items.AddRange(new object[] {
            "Date",
            "Name",
            "Category"});
            this.cmbSort.Location = new System.Drawing.Point(350, 333);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(100, 21);
            this.cmbSort.TabIndex = 3;
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);
            // 
            // lblSort
            // 
            this.lblSort.Location = new System.Drawing.Point(300, 335);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(44, 23);
            this.lblSort.TabIndex = 2;
            this.lblSort.Text = "Sort By:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(110)))), ((int)(((byte)(144)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(200, 333);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search:";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // StayInformed
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(584, 560);
            this.Controls.Add(this.grpAddEvent);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.cmbSort);
            this.Controls.Add(this.flpEvents);
            this.Name = "StayInformed";
            this.grpAddEvent.ResumeLayout(false);
            this.grpAddEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
