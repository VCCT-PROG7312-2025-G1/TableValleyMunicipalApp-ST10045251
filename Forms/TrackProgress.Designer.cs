using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableValleyMunicipalApp.Forms
{
    partial class TrackProgress
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpTrackProgress;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnViewPriority;
        private System.Windows.Forms.Button btnViewGraph;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.FlowLayoutPanel flpRequests;
        private System.Windows.Forms.Label lblTotalRequests;
        private System.Windows.Forms.ComboBox cmbDeptFilter;
        private System.Windows.Forms.Label lblFilterByDept;
        private System.Windows.Forms.ListBox lstRequests;

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
            this.grpTrackProgress = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnViewPriority= new System.Windows.Forms.Button();    
            this.btnViewGraph = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFilterByDept = new System.Windows.Forms.Label();
            this.cmbDeptFilter = new System.Windows.Forms.ComboBox();
            this.flpRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotalRequests = new System.Windows.Forms.Label();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.grpTrackProgress.SuspendLayout();
            this.SuspendLayout();


            //grpTrackProgress
            this.grpTrackProgress.BackColor = Color.FromArgb(255, 253, 245);
            this.grpTrackProgress.Controls.Add(this.lblSearch);
            this.grpTrackProgress.Controls.Add(this.txtSearch);
            this.grpTrackProgress.Controls.Add(this.btnSearch);
            this.grpTrackProgress.Controls.Add(this.lblFilterByDept);
            this.grpTrackProgress.Controls.Add(this.cmbDeptFilter);
            this.grpTrackProgress.Controls.Add(this.btnViewAll);
            this.grpTrackProgress.Controls.Add(this.btnViewPriority);
            this.grpTrackProgress.Controls.Add(this.btnViewGraph);
            this.grpTrackProgress.Controls.Add(this.btnBack);
            this.grpTrackProgress.Location = new System.Drawing.Point(12, 12);
            this.grpTrackProgress.Name = "grpTrackProgress";
            this.grpTrackProgress.Size = new System.Drawing.Size(560, 150);
            this.grpTrackProgress.TabIndex = 0;
            this.grpTrackProgress.TabStop = false;
            this.grpTrackProgress.Text = "Track Service Requests";

            //lblSearch
            this.lblSearch.Location = new System.Drawing.Point(16, 32);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(70, 23);
            this.lblSearch.Text = "Search by ID:";

            //txtSearch
            this.txtSearch.Location = new System.Drawing.Point(95, 32);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 20);

            //btnSearch
            this.btnSearch.BackColor = Color.FromArgb(180, 100, 144);
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = Color.White;
            this.btnSearch.Location = new System.Drawing.Point(240, 30);
            this.btnSearch.Size = new System.Drawing.Size(80, 25);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            //lblFilterByDept
            this.lblFilterByDept.Location = new System.Drawing.Point(16, 70);
            this.lblFilterByDept.Name = "lblFilterByDept";
            this.lblFilterByDept.Size = new System.Drawing.Size(90, 23);
            this.lblFilterByDept.Text = "Filter by Text";

            //cmbDeptFilter
            this.cmbDeptFilter.DropDownStyle = System.Windows.Forms .ComboBoxStyle.DropDownList;
            this.cmbDeptFilter.Items.AddRange(new object[] {
                "All",
                "Sanitation",
                "Plumbing",
                "Roads",
                "Electrical",
                "Maintenance",
                "Community"
            });
            this.cmbDeptFilter.Location = new System.Drawing.Point(110, 67);
            this.cmbDeptFilter.Size = new System.Drawing.Size(130, 21);

            //btnViewAll
            this.btnViewAll.BackColor = Color.FromArgb(180, 100, 144);
            this.btnViewAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAll.ForeColor = Color.White;
            this.btnViewAll.Location = new System.Drawing.Point(260, 65);
            this.btnViewAll.Size = new System.Drawing.Size(80, 25);
            this.btnViewAll.Text = "View all";
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);

            //btnViewPriority
            this.btnViewPriority.BackColor = Color.FromArgb(180, 100, 144);
            this.btnViewPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewPriority.ForeColor = Color.White;
            this.btnViewPriority.Location = new System.Drawing.Point(350, 65);
            this.btnViewPriority.Size = new System.Drawing.Size(90, 25);
            this.btnViewPriority.Text = "By Priority";
            this.btnViewPriority.Click += new System.EventHandler(this.btnViewPriority_Click);

            //btnViewGraph
            this.btnViewGraph.BackColor = Color.FromArgb(180, 100, 144);
            this.btnViewGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewGraph.ForeColor = Color.White;
            this.btnViewGraph.Location = new System.Drawing.Point(450, 65);
            this.btnViewGraph.Size = new System.Drawing.Size(90, 25);
            this.btnViewGraph.Text = "View Graph";
            this.btnViewGraph.Click += new System.EventHandler(this.btnViewGraph_Click);

            //btnBack
            this.btnBack.BackColor = Color.FromArgb(180, 100, 144);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = Color.White;
            this.btnBack.ForeColor = Color.White;
            this.btnBack.Location = new System.Drawing.Point(10, 110);
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);

            //flprequests
            this.flpRequests.AutoScroll = true;
            this.btnViewGraph.BackColor = Color.FromArgb(239, 201, 229);
            this.btnViewGraph.Name = "flprequests";
            this.btnViewGraph.Location = new System.Drawing.Point(12, 175);
            this.btnViewGraph.Size = new System.Drawing.Size(560, 320);
            this.flpRequests.TabIndex = 1;

            //lblTotalRequests
            this.lblTotalRequests.AutoSize = true;
            this.lblTotalRequests.Text = "Total Requests: 0";
            this.lblTotalRequests.Name = "lblTotalRequests";
            this.lblTotalRequests.Location = new System.Drawing.Point(15, 505);
            this.lblTotalRequests.Size = new System.Drawing.Size(19, 13);

            //lstRequests
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.Location = new System.Drawing.Point(20, 120);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(520, 200);
            this.lstRequests.TabIndex = 0;

            //TrackProgressForm
            this.BackColor = System.Drawing.Color.FromArgb(254,253,245);
            this.ClientSize = new System.Drawing.Size(584, 550);
            this.Controls.Add(this.grpTrackProgress);
            this.Controls.Add(this.flpRequests);
            this.Controls.Add(this.lblTotalRequests);
            this.Name = "TrackProgressForm";
            this.Text = "Table Valley - Track Progress";
            this.grpTrackProgress.ResumeLayout(false);
            this.grpTrackProgress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
