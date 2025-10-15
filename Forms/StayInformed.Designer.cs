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

            //grpAddEvent
            this.grpAddEvent.BackColor = Color.FromArgb(255, 253, 245);
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
            this.grpAddEvent.Location = new Point(12, 12);
            this.grpAddEvent.Name = "Add Event";
            this.grpAddEvent.Size = new Size(560, 310);
            this.grpAddEvent.TabIndex = 0;
            this.grpAddEvent.TabStop = false;
            this.grpAddEvent.Text = "Add any Local Event";

            //lblEventName
            this.lblEventName.Location = new Point(20, 50);
            this.lblEventName.Name = "EventName";
            this.lblEventName.Size = new Size(80, 20);
            this.lblEventName.Text = "Enter Event Name:";

            //txtEventName
            this.txtEventName.Location = new Point(110, 47);
            this.txtEventName.Size = new Size(200, 20);

            //lblDate
            this.lblDate.Location = new Point(20, 58);
            this.lblDate.Text = "Date:";

            //dtpEventDate
            this.dtpEventDate.Location = new Point(110, 82);
            this.dtpEventDate.Size = new Size(200, 20);

            //lblCategory
            this.lblCategory.Location = new Point(20, 120);
            this.lblCategory.Text = "Category:";

            //cmbCategory
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Items.AddRange(new object[] {
                "Environment",
                "Community",
                "Sports",
                "Education",
                "Safety",
                "Utilities"
            });
            this.cmbCategory.Location = new Point(110, 117);
            this.cmbCategory.Size = new Size(150, 21);

            //lblLocation
            this.lblLocation.Location = new Point(20, 155);
            this.lblLocation.Text = "Location:";

            //txtLocation
            this.txtLocation.Location = new Point(110, 152);
            this.txtLocation.Size = new Size(200, 20);

            //lblDescription
            this.lblDescription.Location = new Point(20, 190);
            this.lblDescription.Text = "Description:";

            //txtDescription
            this.txtDescription.Location = new Point(110, 187);
            this.txtDescription.Size = new Size(420, 60);
            this.txtDescription.Multiline = true;

            //btnAddEvent
            this.btnAddevent.BackColor = Color.FromArgb(180, 100, 144);
            this.btnAddevent.FlatStyle = FlatStyle.Flat;
            this.btnAddevent.ForeColor = Color.White;
            this.btnAddevent.Location = new Point(450, 265);
            this.btnAddevent.Size = new Size(80, 25);
            this.btnAddevent.Text = "Add Event";
            this.btnAddevent.UseVisualStyleBackColor = false;
            this.btnAddevent.Click += new System.EventHandler(this.btnAddEvent_Click);

            //btnBack
            this.btnBack.BackColor = Color.FromArgb(180, 100, 144);
            this.btnBack.FlatStyle = FlatStyle.Flat;
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Location = new Point(6, 19);
            this.btnBack.Size = new Size(80, 25);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            //txtSearch
            this.txtSearch.Location = new Point(12, 335);
            this.txtSearch.Size = new Size(180, 20);
            this.txtSearch.Text = "Search all events...";
            this.txtSearch.ForeColor = Color.Gray;
            this.txtSearch.GotFocus += (s, e) =>
            {
                if (txtSearch.Text == "Search all events...")
                {
                    txtSearch.Text = "";
                    txtSearch.ForeColor = Color.Black;
                }
            };
            this.txtSearch.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    txtSearch.ForeColor = Color.Gray;
                }

            };

            //btnSearch
            this.btnSearch = new Button();
            this.btnSearch.BackColor = Color.FromArgb(180,110,144);
            this.btnSearch.FlatStyle = FlatStyle.Flat;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new Point(200, 333);
            this.btnSearch.Size = new Size(80, 25);
            this.btnSearch.Text = "Search:";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.Controls.Add(this.btnSearch);

            //lblSort
            this.lblSort.Location = new Point(300, 335);
            this.lblSort.Text = "Sort By:";
            
            //cmbSort
            this.cmbSort.DropDownStyle=ComboBoxStyle.DropDownList;
            this.cmbSort.Items.AddRange(new object[] { "Date", "Name", "Category" });
            this.cmbSort.Location = new Point(350, 333);
            this.cmbSort.Size = new Size(100, 21);
            this.cmbSort.SelectedIndexChanged += new System.EventHandler(this.cmbSort_SelectedIndexChanged);

            //flpEvents
            this.flpEvents.AutoScroll = true;
            this.flpEvents.BackColor = Color.FromArgb(254, 253, 245);
            this.flpEvents.Location = new Point(12, 370);
            this.flpEvents.Size = new Size(560, 170);

            //StayInformed
            this.BackColor = Color.FromArgb(254,253,245);
            this.ClientSize = new Size(584, 560);
            this.Controls.Add(this.grpAddEvent);
            this.Controls.Add(this.txtSearch);
                this.Controls.Add(this.btnSearch);
                this.Controls.Add(this.lblSort);
                this.Controls.Add(this.cmbSort);
                this.Controls.Add(this.flpEvents);
            this.Name = "Events";
            this.grpAddEvent.ResumeLayout(false);
            this.grpAddEvent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
