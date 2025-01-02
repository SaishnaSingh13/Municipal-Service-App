using MunicipalServicesApp;
using System;
using System.Collections.Generic;

namespace MunicipalServiceApp
{
    public class Graph
    {
        /// Dictionary to store service requests, with the request ID as the key
        private Dictionary<int, ServiceRequest> serviceRequests;

        // Constructor to initialize an empty dictionary for service requests
        public Graph()
        {
            serviceRequests = new Dictionary<int, ServiceRequest>(); 
        }

        // Method to add a new service request to the graph using a request ID
        public void AddRequest(int requestId)
        {
            // Check if the request ID does not already exist in the dictionary
            if (!serviceRequests.ContainsKey(requestId))
            {
                // Add a new ServiceRequest object with default properties if the ID is not found
                serviceRequests.Add(requestId, new ServiceRequest(requestId, "Unknown issue", "Unknown", DateTime.Now));
            }
        }
    }
}
