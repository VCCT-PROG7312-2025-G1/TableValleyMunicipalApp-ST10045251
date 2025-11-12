using System;
using System.Linq;
using System.Windows.Forms;
using TableValleyMunicipalApp.Class;
using TableValleyMunicipalApp.DataStructures;

namespace TableValleyMunicipalApp.Forms
{
    public partial class TrackProgress : Form
    {
        private BinarySearchTree requestTree;
        private PriorityQueue<ServiceRequest> priorityQueue;
        private Graph requestGraph;

        public TrackProgress()
        {
            InitializeComponent();

            requestTree = new BinarySearchTree();
            priorityQueue = new PriorityQueue<ServiceRequest>();
            requestGraph = new Graph();

            LoadSampleRequests();
            DisplayRequests();
        }

        private void LoadSampleRequests()
        {
            //Sample Data
            ServiceRequest r1 = new ServiceRequest(1, "Water Leakage", "Plumbing", "Pending", 2);
            ServiceRequest r2 = new ServiceRequest(2, "PoteHoles", "Roads", "In Progress", 3);
            ServiceRequest r3 = new ServiceRequest(3, "Clean-up", "Environment", "Completed", 1);

            //Adding to tree
            requestTree.Insert(r1);
            requestTree.Insert(r2);
            requestTree.Insert(r3);

            //adding to priority queue
            priorityQueue.Enqueue(r1);
            priorityQueue.Enqueue(r2);
            priorityQueue.Enqueue(r3);

            //creating a relationship in the graph
            requestGraph.AddEdge("Water leakage", "Plumbing Dept");
            requestGraph.AddEdge("Streetlight not working", "Electrical Dept");
            requestGraph.AddEdge("Blocked drain", "Sanitation Dept");
        }

        private void DisplayRequests()
        {
            lstRequests.Items.Clear();
            foreach (var req in requestTree.InOrderTraversal())
            {
                lstRequests.Items.Add($"{req.requestID} - {req.Description} | {req.Department} | Status: {req.Status}");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                var found = requestTree.Search(id);
                if (found != null)
                {
                    MessageBox.Show(
                        $"Found Request #{found.requestID}\n" +
                        $"Status: {found.Status}\n" +
                        $"Department: {found.Department}",
                        "Request Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No request found with that ID.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Request ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPriorityView_Click(object sender, EventArgs e)
        {
            string output = "Priority Requests:\n\n";
            foreach (var req in priorityQueue.ToList())
                output += $"{req.requestID} - {req.Description} (Priority: {req.Priority})";
            MessageBox.Show(output);
        }

        private void btnGraphView_Click(object sender, EventArgs e)
        {
            string output = requestGraph.DisplayGraph();
            MessageBox.Show(output, "Department Relationships");
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            DisplayRequests();
        }

        private void btnViewPriority_Click(object sender, EventArgs e)
        {
            lstRequests.Items.Clear(); // Clear existing items

            var requestsByPriority = priorityQueue.ToList(); // Get requests from PriorityQueue

            if (requestsByPriority.Count == 0)
            {
                MessageBox.Show("No requests available in the priority queue.",
                    "Empty Queue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var req in requestsByPriority)
            {
                lstRequests.Items.Add($"[{req.Priority}] {req.requestID} - {req.Description} | {req.Department} | Status: {req.Status}");
            }

            MessageBox.Show("Requests are displayed in order of priority (lowest = highest urgency).",
                "Priority View", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnViewGraph_Click(object sender, EventArgs e)
        {
            string graphOutput = requestGraph.DisplayGraph();

            if (string.IsNullOrWhiteSpace(graphOutput))
            {
                MessageBox.Show("No department relationships found.",
                    "Graph Empty", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(graphOutput,
                    "Department Relationships", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
