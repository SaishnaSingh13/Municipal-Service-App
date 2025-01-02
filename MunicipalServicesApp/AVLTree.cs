using System;


namespace MunicipalServicesApp
{
    public class AVLTree

    {
        // Define a node in the AVL tree that stores a ServiceRequest
        private class Node
        {
            public ServiceRequest Request;
            public Node Left, Right;
            public int Height;

            public Node(ServiceRequest request)
            {
                Request = request;
                Left = Right = null;
                Height = 1;
            }
        }

        private Node root;

        // Public method to insert a ServiceRequest into the AVL tree
        public void Insert(ServiceRequest request)
        {
            root = Insert(root, request);
        }

        // Private recursive method to insert a ServiceRequest into the tree
        private Node Insert(Node node, ServiceRequest request)
        {
            // If the node is null, we create a new node for the request
            if (node == null) return new Node(request);

            // Standard Binary Search Tree (BST) insertion logic
            if (request.Id < node.Request.Id)
                node.Left = Insert(node.Left, request);
            else if (request.Id > node.Request.Id)
                node.Right = Insert(node.Right, request);
            else
                return node;

            // Update the height of this ancestor node
            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

            // Get the balance factor of this node to determine if the tree is unbalanced
            int balance = GetBalance(node);

            // Perform rotations if necessary
            if (balance > 1 && request.Id < node.Left.Request.Id)
                return RotateRight(node);

            if (balance < -1 && request.Id > node.Right.Request.Id)
                return RotateLeft(node);

            if (balance > 1 && request.Id > node.Left.Request.Id)
            {
                node.Left = RotateLeft(node.Left);
                return RotateRight(node);
            }

            if (balance < -1 && request.Id < node.Right.Request.Id)
            {
                node.Right = RotateRight(node.Right);
                return RotateLeft(node);
            }

            return node;
        }

        // Public method to find a ServiceRequest by its ID
        public ServiceRequest Find(int id)
        {
            return Find(root, id);
        }

        // Private method to recursively search for a request in the tree
        private ServiceRequest Find(Node node, int id)
        {
            if (node == null) return null;

            // Check if this node's ID matches
            if (id == node.Request.Id)
                return node.Request;

            // Recursively search in the left or right subtree
            if (id < node.Request.Id)
                return Find(node.Left, id);

            return Find(node.Right, id);
        }

        // Helper method to get the height of a node (0 if null)
        private int GetHeight(Node node)
        {
            return node == null ? 0 : node.Height;
        }

        // Helper method to calculate the balance factor 
        private int GetBalance(Node node)
        {
            return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
        }

        // Helper method to perform a right rotation to balance the tree
        private Node RotateRight(Node y)
        {
            Node x = y.Left;
            Node T2 = x.Right;

            //rotation
            x.Right = y;
            y.Left = T2;

            // heights
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            return x;
        }

        // Helper method to perform a left rotation to balance the tree
        private Node RotateLeft(Node x)
        {
            Node y = x.Right;
            Node T2 = y.Left;

            // rotation
            y.Left = x;
            x.Right = T2;

            // heights
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            return y;
        }
    }
}
