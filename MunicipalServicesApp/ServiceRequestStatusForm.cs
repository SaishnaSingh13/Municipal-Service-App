using MunicipalServicesApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MunicipalServiceApp
{
    // Fields for different data structures to manage service requests
    public partial class ServiceRequestStatusForm : Form
    {
        private BinarySearchTree serviceRequestBST;
        private AVLTree serviceRequestAVL;
        private MinHeap serviceRequestHeap;
        private Graph serviceRequestGraph;

        // Initializes the form and data structures
        public ServiceRequestStatusForm()
        {
            InitializeComponent();
            serviceRequestBST = new BinarySearchTree();
            serviceRequestAVL = new AVLTree();
            serviceRequestHeap = new MinHeap();
            serviceRequestGraph = new Graph();

            LoadSampleData();
            DisplayAllRequests();
        }

        // Loads sample service requests into data structures for testing
        private void LoadSampleData()
        {
            var request1 = new ServiceRequest(1122, "The issue with water supply disruption, currently under investigation.", "In Progress", DateTime.Now.AddDays(-2));
            var request2 = new ServiceRequest(3344, "The issue with traffic signal malfunction, repair scheduled for tomorrow.", "Scheduled", DateTime.Now.AddDays(-1));
            var request3 = new ServiceRequest(5566, "Request for road maintenance due to cracks in the pavement.", "In Queue", DateTime.Now.AddDays(-7));

            // Insert sample requests into various data structures
            serviceRequestBST.Insert(request1);
            serviceRequestAVL.Insert(request2);
            serviceRequestHeap.Insert(request3);

            // Add request IDs to the graph
            serviceRequestGraph.AddRequest(request1.Id);
            serviceRequestGraph.AddRequest(request2.Id);
            serviceRequestGraph.AddRequest(request3.Id);
        }

        // Displays all service requests in the list box
        private void DisplayAllRequests()
        {
            listBoxRequests.Items.Clear();

            // Example data for demonstration - replace with actual data retrieval logic
            var requests = new List<ServiceRequest>
    {  
                new ServiceRequest(1122, "The issue with water supply disruption.", "In Progress", DateTime.Now.AddDays(-2)),
                new ServiceRequest(3344, "The issue with traffic signal malfunction.", "Scheduled", DateTime.Now.AddDays(-1)),
                new ServiceRequest(5566, "Request for road maintenance.", "In Queue", DateTime.Now.AddDays(-7)),
    };

            // Add each request to the list box for display
            foreach (var request in requests)
            {
                listBoxRequests.Items.Add($"{request.Id}: {request.Description}");
            }
        }


        // Handles the search button click event to find and display a service request
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRequestId.Text, out int requestId))
            {
                ServiceRequest request = null;

                // Attempt to find the request in the Binary Search Tree
                request = serviceRequestBST.Find(requestId);

                // If not found in BST, try searching in the AVL Tree
                if (request == null)
                    request = serviceRequestAVL.Find(requestId);

                // If not found in AVLTree, search in MinHeap 
                if (request == null)
                    request = FindInHeap(requestId);

                // Display message if request not found
                if (request == null)
                    MessageBox.Show("Request ID not found in any data structure.");
                else
                {
                    lblStatus.Text = $"Status: {request.Status}";
                    lblDescription.Text = $"Description: {request.Description}";
                }
            }
            else
            {
                MessageBox.Show("Invalid Request ID.");
            }
        }

        // Searches for a service request in the MinHeap by iterating through all items
        private ServiceRequest FindInHeap(int requestId)
        {
            // Iterate over each request in the MinHeap to find a match
            foreach (var request in serviceRequestHeap.GetAllRequests())
            {
                if (request.Id == requestId)
                    return request;
            }
            return null; 
        }

        // Handles the close button click event to close the form
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


