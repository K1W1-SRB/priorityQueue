using System;

namespace PriorityQueue
{
    public class UnsortedArrayPriorityQueue<T> : PriorityQueue<T>
    {
        private readonly PriorityItem<T>[] storage;
        private readonly int capacity;
        private int count;

        public UnsortedArrayPriorityQueue(int size)
        {
            storage = new PriorityItem<T>[size];
            capacity = size;
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }
        // Exeption handeling for empty array
        public T Head()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }
            return storage[FindHighestPriorityIndex()].Item;
        }

        // Exeption handeling for full aray
        public void Add(T item, int priority)
        {
            if (count >= capacity)
            {
                throw new QueueOverflowException();
            }
            storage[count++] = new PriorityItem<T>(item, priority);
        }

        // Removes top priority from array using my findhigheset priority index function to move that priority to the end of the array to remove it 
        public void Remove()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException();
            }

            int highestPriorityIndex = FindHighestPriorityIndex();

            // Shift last item into the removed slot
            storage[highestPriorityIndex] = storage[count - 1];
            count--;
        }

       
        //this function is just used to display the array to the user when show array is clicked 
        public override string ToString()
        {
            if (IsEmpty())
            {
                throw new QueueUnderflowException("No items to display");
            }

            string result = "[";
            for (int i = 0; i < count; i++)
            {
                if (i > 0)
                {
                    result += ", ";
                }
                result += storage[i];
            }
            result += "]";
            return result;
        }

        // loops throught the size of the array and checks if the priority is higher then the current one and replaces it if it is to calculate the highest priority 
        private int FindHighestPriorityIndex()
        {
            int highestPriorityIndex = 0;
            for (int i = 1; i < count; i++)
            {
                if (storage[i].Priority > storage[highestPriorityIndex].Priority)
                {
                    highestPriorityIndex = i;
                }
            }
            return highestPriorityIndex;
        }
    }
}