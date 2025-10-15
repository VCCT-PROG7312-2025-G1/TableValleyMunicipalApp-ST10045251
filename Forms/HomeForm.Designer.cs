namespace TableValleyMunicipalApp.Forms
{
    partial class HomeForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddViewIssues;
        private System.Windows.Forms.Button btnTrackProgress;
        private System.Windows.Forms.Button btnStayInformed;
        private System.Windows.Forms.PictureBox picLogo;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddViewIssues = new System.Windows.Forms.Button();
            this.btnTrackProgress = new System.Windows.Forms.Button();
            this.btnStayInformed = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flpIssues = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.flpIssues.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(106, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(498, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Table Valley Municipal App";
            // 
            // btnAddViewIssues
            // 
            this.btnAddViewIssues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddViewIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.btnAddViewIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddViewIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddViewIssues.ForeColor = System.Drawing.Color.White;
            this.btnAddViewIssues.Location = new System.Drawing.Point(48, 364);
            this.btnAddViewIssues.Name = "btnAddViewIssues";
            this.btnAddViewIssues.Size = new System.Drawing.Size(187, 50);
            this.btnAddViewIssues.TabIndex = 2;
            this.btnAddViewIssues.Text = "Add Issues";
            this.btnAddViewIssues.UseVisualStyleBackColor = false;
            this.btnAddViewIssues.Click += new System.EventHandler(this.btnAddViewIssues_Click);
            // 
            // btnTrackProgress
            // 
            this.btnTrackProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.btnTrackProgress.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnTrackProgress.Location = new System.Drawing.Point(650, 364);
            this.btnTrackProgress.Name = "btnTrackProgress";
            this.btnTrackProgress.Size = new System.Drawing.Size(187, 50);
            this.btnTrackProgress.TabIndex = 3;
            this.btnTrackProgress.Text = "Track Progress";
            this.btnTrackProgress.UseVisualStyleBackColor = false;
            // 
            // btnStayInformed
            // 
            this.btnStayInformed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.btnStayInformed.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStayInformed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnStayInformed.Location = new System.Drawing.Point(349, 363);
            this.btnStayInformed.Name = "btnStayInformed";
            this.btnStayInformed.Size = new System.Drawing.Size(187, 50);
            this.btnStayInformed.TabIndex = 4;
            this.btnStayInformed.Text = "Stay Informed";
            this.btnStayInformed.UseVisualStyleBackColor = false;
            this.btnStayInformed.Click += new System.EventHandler(this.btnStayInformed_Click);
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(885, 100);
            this.label1.TabIndex = 5;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flpIssues
            // 
            this.flpIssues.AutoScroll = true;
            this.flpIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.flpIssues.Controls.Add(this.label3);
            this.flpIssues.Location = new System.Drawing.Point(48, 201);
            this.flpIssues.Name = "flpIssues";
            this.flpIssues.Size = new System.Drawing.Size(187, 214);
            this.flpIssues.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(349, 201);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(187, 213);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(651, 201);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(187, 214);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 120);
            this.label2.TabIndex = 11;
            this.label2.Text = "View any upcoming commuinty\r\nmeetings, events or important \r\npublic notices in yo" +
    "ur area.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 160);
            this.label3.TabIndex = 12;
            this.label3.Text = "Log any problem whether it be, water leaks, \r\npotholes or power outages, \r\ndirect" +
    "ly to your municipailty for a faster resolution.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 105);
            this.label4.TabIndex = 13;
            this.label4.Text = "Check the progress of your reported issues \r\nand see which have been resolved \r\nb" +
    "y the municipality.";
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(938, 442);
            this.Controls.Add(this.btnTrackProgress);
            this.Controls.Add(this.btnStayInformed);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnAddViewIssues);
            this.Controls.Add(this.flpIssues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Name = "HomeForm";
            this.Text = "Home - Table Valley";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.flpIssues.ResumeLayout(false);
            this.flpIssues.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpIssues;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
