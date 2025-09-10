using System;
using System.Drawing;
using System.Windows.Forms;
using TableValleyMunicipalApp.DataStructures;
using TableValleyMunicipalApp.Models;

namespace TableValleyMunicipalApp.Forms
{
    public partial class MainForm : Form
    {
        private IssuesLinkedList issues = new IssuesLinkedList();
        private string selectedAttachmentPath = string.Empty;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var issue = new Issue
            {
                Location = txtLocation.Text,
                Category = comboBoxCategory.SelectedItem?.ToString() ?? "Unspecified",
                Description = txtDescription.Text,
                Attachment = selectedAttachmentPath
            };

            // Add issue panel
            Panel pnl = new Panel
            {
                Width = flpIssues.Width - 25,
                Height = 80,
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox pb = new PictureBox
            {
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.Zoom,
                Location = new Point(5, 15)
            };
            pnl.Controls.Add(pb);

            Label lblText = new Label
            {
                Text = $"{issue.Category} - {issue.Location}\n{issue.Description}\nAttachment: {System.IO.Path.GetFileName(issue.Attachment)}",
                Location = new Point(60, 10),
                Size = new Size(380, 60)
            };
            pnl.Controls.Add(lblText);

            Label lblStatus = new Label
            {
                Text = "Pending",
                BackColor = Color.Orange,
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Width = 80,
                Height = 25,
                Location = new Point(450, 25)
            };
            pnl.Controls.Add(lblStatus);

            flpIssues.Controls.Add(pnl);

            // Reset input fields
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtLocation.Clear();
            txtDescription.Clear();
            comboBoxCategory.SelectedIndex = 0;
            selectedAttachmentPath = string.Empty;
            lblAttachmentPath.Text = "No file selected";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    lblAttachmentPath.Text = ofd.FileName;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close();
        }
    }
}
