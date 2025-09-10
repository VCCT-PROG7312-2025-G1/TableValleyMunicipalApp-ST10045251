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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddViewIssues = new System.Windows.Forms.Button();
            this.btnTrackProgress = new System.Windows.Forms.Button();
            this.btnStayInformed = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(79)))), ((int)(((byte)(80)))));
            this.lblTitle.Location = new System.Drawing.Point(22, 53);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(466, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to Table Valley Municipal App";
            // 
            // btnAddViewIssues
            // 
            this.btnAddViewIssues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(128)))), ((int)(((byte)(173)))));
            this.btnAddViewIssues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddViewIssues.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddViewIssues.ForeColor = System.Drawing.Color.White;
            this.btnAddViewIssues.Location = new System.Drawing.Point(124, 111);
            this.btnAddViewIssues.Name = "btnAddViewIssues";
            this.btnAddViewIssues.Size = new System.Drawing.Size(200, 50);
            this.btnAddViewIssues.TabIndex = 2;
            this.btnAddViewIssues.Text = "Add Issues";
            this.btnAddViewIssues.UseVisualStyleBackColor = false;
            this.btnAddViewIssues.Click += new System.EventHandler(this.btnAddViewIssues_Click);
            // 
            // btnTrackProgress
            // 
            this.btnTrackProgress.Location = new System.Drawing.Point(124, 181);
            this.btnTrackProgress.Name = "btnTrackProgress";
            this.btnTrackProgress.Size = new System.Drawing.Size(200, 50);
            this.btnTrackProgress.TabIndex = 3;
            this.btnTrackProgress.Text = "Track Progress";
            // 
            // btnStayInformed
            // 
            this.btnStayInformed.Location = new System.Drawing.Point(124, 253);
            this.btnStayInformed.Name = "btnStayInformed";
            this.btnStayInformed.Size = new System.Drawing.Size(200, 50);
            this.btnStayInformed.TabIndex = 4;
            this.btnStayInformed.Text = "Stay Informed";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(100, 50);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // HomeForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnAddViewIssues);
            this.Controls.Add(this.btnTrackProgress);
            this.Controls.Add(this.btnStayInformed);
            this.Name = "HomeForm";
            this.Text = "Home - Table Valley";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
