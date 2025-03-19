using System;

namespace PriorityQueue
{
    public class SortedLinkedPriorityQueue<T> : PriorityQueue<T>
    {
        private Node head;
        private readonly PriorityItem<T>[] storage;
        private readonly int capacity;
        private int tailIndex;

        private class Node
        {
            public T Item { get; set; }
            public int Priority { get; set; }
            public Node Next { get; set; }

            public Node(T item, int priority)
            {
                Item = item;
                Priority = priority;
                Next = null;
            }
        }

        public SortedLinkedPriorityQueue(int size)
        {
            storage = new PriorityItem<T>[size];
            capacity = size;
            tailIndex = -1;
        }

        // ✅ Peek at the highest priority item (which is always at the head)
        public T Head()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            return head.Item;
        }

        // ✅ Add a new item while maintaining sorted order
        public void Add(T item, int priority)
        {
            Node newNode = new Node(item, priority);

            if (head == null || head.Priority < priority)
            {
                // Insert at the head if the list is empty or new item has higher priority
                newNode.Next = head;
                head = newNode;
            }
            else
            {
                // Traverse the list and insert the node in sorted order
                Node current = head;
                Node previous = null;

                while (current != null && current.Priority >= priority)
                {
                    previous = current;
                    current = current.Next;
                }

                // Insert the new node between previous and current
                newNode.Next = current;

                if (previous != null)
                {
                    previous.Next = newNode;
                }
            }
        }

        // ✅ Remove the highest priority item (head of the list)
        public void Remove()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            head = head.Next;
        }

        // ✅ Check if the queue is empty
        public bool IsEmpty()
        {
            return head == null;
        }

        // ✅ ToString method to display the queue
        public override string ToString()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("No items to display");
            }

            string result = "[";
            Node current = head;

            while (current != null)
            {
                if (current != head)
                {
                    result += ", ";
                }

                result += $"{current.Item} (Priority: {current.Priority})";
                current = current.Next;
            }

            result += "]";
            return result;
        }
    }
}
