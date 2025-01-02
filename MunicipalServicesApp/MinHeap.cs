using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class MinHeap
    {
        // Array to store heap elements
        private ServiceRequest[] heap;

        // Current number of elements in the heap
        private int size;

        // Initializes the heap with an optional initial capacity
        public MinHeap(int capacity = 10)
        {
            heap = new ServiceRequest[capacity];
            size = 0;
        }

        // Returns all ServiceRequests currently in the heap as an array
        public ServiceRequest[] GetAllRequests()
        {
            var allRequests = new ServiceRequest[size];
            Array.Copy(heap, allRequests, size);
            return allRequests;
        }


        // Adds a new ServiceRequest to the heap and maintains the heap property
        public void Insert(ServiceRequest request)
        {
            if (size >= heap.Length)
                Resize();

            heap[size] = request;
            size++;
            HeapifyUp();
        }

        // Removes and returns the minimum element (root) from the heap
        public ServiceRequest RemoveMin()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty.");

            var min = heap[0];

            heap[0] = heap[size - 1];
            size--;
            HeapifyDown(0);

            return min;
        }

        // Returns the minimum element without removing it
        public ServiceRequest PeekMin()
        {
            if (size == 0)
                throw new InvalidOperationException("Heap is empty.");

            return heap[0];
        }

        // Moves the last inserted element up to its correct position
        private void HeapifyUp()
        {
            int index = size - 1;

            while (index > 0 && heap[Parent(index)].Id > heap[index].Id)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }
        }

        // Moves the element at the specified index down to its correct position
        private void HeapifyDown(int index)
        {
            int leftChild = LeftChild(index);
            int rightChild = RightChild(index);
            int smallest = index;

            if (leftChild < size && heap[leftChild].Id < heap[smallest].Id)
                smallest = leftChild;

            if (rightChild < size && heap[rightChild].Id < heap[smallest].Id)
                smallest = rightChild;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        // Swaps two elements in the heap
        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        // Returns the index of the parent of the node at the given index
        private int Parent(int index) => (index - 1) / 2;

        // Returns the index of the left child of the node at the given index
        private int LeftChild(int index) => 2 * index + 1;

        // Returns the index of the right child of the node at the given index
        private int RightChild(int index) => 2 * index + 2;

        // Doubles the size of the heap array when it's full
        private void Resize()
        {
            var newHeap = new ServiceRequest[heap.Length * 2];
            Array.Copy(heap, 0, newHeap, 0, heap.Length);
            heap = newHeap;
        }
    }
}
