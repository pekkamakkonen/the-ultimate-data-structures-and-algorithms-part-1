using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Array
    {
        private int[] items;
        private int count;

        public Array(int length)
        {
            items = new int[length];
        }

        public void Insert(int item)
        {
            // If the array is full, resize it
            if (items.Length == count)
            {
                // Create a new array (twice the size)
                int[] newItems = new int[count * 2];

                // Copy all the existing items
                for (int i = 0; i < count; i++)
                    newItems[i] = items[i];

                // Set "items" to this new array
                items = newItems;
            }

            // Add the new item at the end
            items[count++] = item;
        }

        public void RemoveAt(int index)
        {
            // Validate the index
            if (index < 0 || index >= count) // 4
                throw new IndexOutOfRangeException();

            // Shift the items to the left to fill the hole
            // [10, 20, 30, 40]
            // index: 1
            // 1 <- 2
            // 2 <- 3
            for (int i = index; i< count; i++)            
                items[i] = items[i + 1];
            count--;
        }

        public int IndexOf(int item)
        {
            // If we find it, return index
            // Otherwise, return -1
            // O(1)
            // O(n)
            for (int i = 0; i < count; i++)
                if (items[i] == item)
                    return i;

            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(items[i]);
        }
    }
}
