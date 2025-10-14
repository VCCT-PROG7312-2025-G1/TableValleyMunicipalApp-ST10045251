using System.Drawing;

namespace TableValleyMunicipalApp.Forms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.GroupBox grpAddIssue;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblAttachment;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.FlowLayoutPanel flpIssues;
        private System.Windows.Forms.Label lblAttachmentPath;
        private System.Windows.Forms.Button btnBack;

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
            this.grpAddIssue = new System.Windows.Forms.GroupBox();
            this.lblAttachmentPath = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblAttachment = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.flpIssues = new System.Windows.Forms.FlowLayoutPanel();
            this.grpAddIssue.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddIssue
            // 
            this.grpAddIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.grpAddIssue.Controls.Add(this.lblAttachmentPath);
            this.grpAddIssue.Controls.Add(this.lblLocation);
            this.grpAddIssue.Controls.Add(this.txtLocation);
            this.grpAddIssue.Controls.Add(this.lblCategory);
            this.grpAddIssue.Controls.Add(this.comboBoxCategory);
            this.grpAddIssue.Controls.Add(this.lblDescription);
            this.grpAddIssue.Controls.Add(this.txtDescription);
            this.grpAddIssue.Controls.Add(this.lblAttachment);
            this.grpAddIssue.Controls.Add(this.btnBrowse);
            this.grpAddIssue.Controls.Add(this.btnAdd);
            this.grpAddIssue.Controls.Add(this.btnBack);
            this.grpAddIssue.Location = new System.Drawing.Point(12, 12);
            this.grpAddIssue.Name = "grpAddIssue";
            this.grpAddIssue.Size = new System.Drawing.Size(560, 308);
            this.grpAddIssue.TabIndex = 0;
            this.grpAddIssue.TabStop = false;
            this.grpAddIssue.Text = "Report an Issue";
            // 
            // lblAttachmentPath
            // 
            this.lblAttachmentPath.AutoSize = true;
            this.lblAttachmentPath.Location = new System.Drawing.Point(97, 268);
            this.lblAttachmentPath.Name = "lblAttachmentPath";
            this.lblAttachmentPath.Size = new System.Drawing.Size(80, 13);
            this.lblAttachmentPath.TabIndex = 0;
            this.lblAttachmentPath.Text = "No file selected";
            // 
            // lblLocation
            // 
            this.lblLocation.Location = new System.Drawing.Point(15, 64);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(59, 23);
            this.lblLocation.TabIndex = 0;
            this.lblLocation.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(90, 64);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(186, 20);
            this.txtLocation.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(15, 120);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(59, 23);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Water",
            "Roads",
            "Electricity",
            "Sanitation",
            "Other"});
            this.comboBoxCategory.Location = new System.Drawing.Point(90, 117);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(150, 21);
            this.comboBoxCategory.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(15, 184);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(69, 23);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(90, 166);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(440, 60);
            this.txtDescription.TabIndex = 5;
            // 
            // lblAttachment
            // 
            this.lblAttachment.Location = new System.Drawing.Point(15, 242);
            this.lblAttachment.Name = "lblAttachment";
            this.lblAttachment.Size = new System.Drawing.Size(69, 23);
            this.lblAttachment.TabIndex = 6;
            this.lblAttachment.Text = "Attachment:";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(90, 242);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(107, 23);
            this.btnBrowse.TabIndex = 7;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(144)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(450, 277);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 25);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add Issue";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(100)))), ((int)(((byte)(144)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(4, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(80, 25);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // flpIssues
            // 
            this.flpIssues.AutoScroll = true;
            this.flpIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(201)))), ((int)(((byte)(229)))));
            this.flpIssues.Location = new System.Drawing.Point(12, 340);
            this.flpIssues.Name = "flpIssues";
            this.flpIssues.Size = new System.Drawing.Size(560, 190);
            this.flpIssues.TabIndex = 1;
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(253)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(584, 550);
            this.Controls.Add(this.grpAddIssue);
            this.Controls.Add(this.flpIssues);
            this.Name = "MainForm";
            this.Text = "Table Valley - Municipal App";
            this.grpAddIssue.ResumeLayout(false);
            this.grpAddIssue.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
