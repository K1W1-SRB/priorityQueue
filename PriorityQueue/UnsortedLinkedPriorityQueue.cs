using System;

namespace PriorityQueue
{
    public class UnsortedLinkedPriorityQueue<T> : PriorityQueue<T>
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

        public UnsortedLinkedPriorityQueue(int size)
        {
            storage = new PriorityItem<T>[size];
            capacity = size;
            tailIndex = -1;
        }

        public T Head()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            Node highestPriorityNode = head;
            Node current = head;

            while (current != null)
            {
                if (current.Priority > highestPriorityNode.Priority)
                {
                    highestPriorityNode = current;
                }
                current = current.Next;
            }

            return highestPriorityNode.Item;
        }

        public void Add(T item, int priority)
        {
            Node newNode = new Node(item, priority);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
        }

        public void Remove()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            Node highestPriorityNode = head;
            Node prev = null;
            Node current = head;

         
            while (current != null)
            {
                if (current.Priority > highestPriorityNode.Priority)
                {
                    highestPriorityNode = current;
                    prev = current;
                }
                current = current.Next;
            }

            
            if (prev == null)
            {
                head = highestPriorityNode.Next;
            }
            else
            {
                prev.Next = highestPriorityNode.Next;
            }
        }

        public bool IsEmpty()
        {
            return head == null;
        }

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
