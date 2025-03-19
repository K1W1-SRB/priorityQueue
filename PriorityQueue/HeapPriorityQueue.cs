using System;

namespace PriorityQueue
{
    public class HeapPriorityQueue<T> : PriorityQueue<T>
    {
        private class HeapNode
        {
            public T Item { get; set; }
            public int Priority { get; set; }

            public HeapNode(T item, int priority)
            {
                Item = item;
                Priority = priority;
            }
        }

        private HeapNode[] heap;
        private int size;
        private readonly int capacity;

        public HeapPriorityQueue(int capacity)
        {
            this.capacity = capacity;
            heap = new HeapNode[capacity];
            size = 0;
        }

        public void Add(T item, int priority)
        {
            if (size >= capacity)
            {
                throw new QueueOverflowException("Queue is full");
            }

            var newNode = new HeapNode(item, priority);
            heap[size] = newNode;
            HeapifyUp(size);   
            size++;
        }

        public void Remove()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("Queue is empty");
            }

            heap[0] = heap[size - 1];  
            heap[size - 1] = null;    
            size--;

            HeapifyDown(0);           
        }

  
        public T Head()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("Queue is empty");
            }

            return heap[0].Item;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

  
        public override string ToString()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("No items to display");
            }

            string result = "[";
            for (int i = 0; i < size; i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += $"{heap[i].Item} (Priority: {heap[i].Priority})";
            }
            result += "]";
            return result;
        }

        private void HeapifyUp(int index)
        {
            while (index > 0)
            {
                int parentIndex = (index - 1) / 2;

                // Max-heap: Compare with parent, swap if current has higher priority
                if (heap[index].Priority <= heap[parentIndex].Priority)
                {
                    break;
                }

                Swap(index, parentIndex);
                index = parentIndex;
            }
        }

       
        private void HeapifyDown(int index)
        {
            while (true)
            {
                int leftChild = 2 * index + 1;
                int rightChild = 2 * index + 2;
                int largest = index;

                if (leftChild < size && heap[leftChild].Priority > heap[largest].Priority)
                {
                    largest = leftChild;
                }

                if (rightChild < size && heap[rightChild].Priority > heap[largest].Priority)
                {
                    largest = rightChild;
                }

                if (largest == index)
                {
                    break;
                }

                Swap(index, largest);
                index = largest;
            }
        }

       
        private void Swap(int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
