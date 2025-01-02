using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class BinarySearchTree
    {
        // Internal class representing a node in the binary search tree
        private class Node
        {
            public ServiceRequest Request;
            public Node Left, Right;

            // Constructor to create a node with the given service request
            public Node(ServiceRequest request)
            {
                Request = request;
                Left = Right = null;
            }
        }

        // The root node of the binary search tree
        private Node root;

        // Public method to insert a service request into the tree
        public void Insert(ServiceRequest request)
        {
            root = Insert(root, request);
        }

        // Private recursive method to insert a new node in the correct position
        private Node Insert(Node node, ServiceRequest request)
        {
            if (node == null) return new Node(request);

            // Insert the node based on the ID
            if (request.Id < node.Request.Id)
                node.Left = Insert(node.Left, request);
            else if (request.Id > node.Request.Id)
                node.Right = Insert(node.Right, request);

            return node;
        }

        // Public method to find a service request by its ID
        public ServiceRequest Find(int id)
        {
            return Find(root, id);
        }

        // Private recursive method to search for a service request by ID
        private ServiceRequest Find(Node node, int id)
        {
            if (node == null) return null;

            
            if (id == node.Request.Id)
                return node.Request;

            
            if (id < node.Request.Id)
                return Find(node.Left, id);

            return Find(node.Right, id);
        }
    }
}
