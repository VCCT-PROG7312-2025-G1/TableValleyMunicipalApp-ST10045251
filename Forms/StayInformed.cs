using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics.Tracing;

namespace TableValleyMunicipalApp.Forms
{

    public partial class StayInformed : Form
    {

        private List<EventData> events = new List<EventData>();

        public StayInformed()
        {
            InitializeComponent();
        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEventName.Text) ||
                string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EventData newEvent = new EventData
            {
                Name = txtEventName.Text,
                Date = dtpEventDate.Value,
                Category = cmbCategory.SelectedItem?.ToString() ?? "General",
                Location = txtLocation.Text,
                Description = txtDescription.Text
            };

            events.Add(newEvent);
            DisplayEvents(events);

            txtEventName.Clear();
            txtLocation.Clear();
            txtDescription.Clear();
            cmbCategory.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text.ToLower();
            var results = events.FindAll(ev =>
                ev.Name.ToLower().Contains(search) ||
                ev.Category.ToLower().Contains(search) ||
                ev.Location.ToLower().Contains(search)
            );

            DisplayEvents(results);
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbSort.SelectedItem?.ToString() ?? "";
            List<EventData> sortedList = new List<EventData>(events);

            switch (selected)
            {
                case "Date":
                    sortedList.Sort((a, b) => a.Date.CompareTo(b.Date));
                    break;
                case "Name":
                    sortedList.Sort((a, b) => string.Compare(a.Name, b.Name, StringComparison.OrdinalIgnoreCase));
                    break;
                case "Category":
                    sortedList.Sort((a, b) => string.Compare(a.Category, b.Category, StringComparison.OrdinalIgnoreCase));
                    break;
            }

            DisplayEvents(sortedList);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
            this.Close(); 
        }

        private void DisplayEvents(List<EventData> list)
        {
            flpEvents.Controls.Clear();

            foreach (var ev in list)
            {
                Panel card = new Panel
                {
                    BackColor = Color.FromArgb(255, 240, 250),
                    Width = 520,
                    Height = 80,
                    Margin = new Padding(5)
                };

                Label lbl = new Label
                {
                    Text = $"{ev.Date:dd MM yyyy} - {ev.Name}\nCategory: {ev.Category}\nLocation: {ev.Location}\n{ev.Description}",
                    AutoSize = false,
                    Dock = DockStyle.Fill
                };

                card.Controls.Add(lbl);
                flpEvents.Controls.Add(card);
            }
        }
    }

    public class EventData
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}


