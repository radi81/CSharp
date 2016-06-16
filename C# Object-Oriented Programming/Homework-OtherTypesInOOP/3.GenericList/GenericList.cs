using System;
using System.Linq;
using System.Text;

namespace _3.GenericList
{
    public class GenericList<T> 
    {
        private const int DefaultCapacity = 16;

        private T[] array;
        private int capacity;
        private int currentIndex;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.array = new T[DefaultCapacity];
            this.Capacity = capacity;
            int currentIndex = 0;
        }
            
        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                if (value < DefaultCapacity)
                {
                    value = DefaultCapacity;
                }
                this.capacity = value;
            }
        }

        // Adding an element
        public void AddElement(T element)
        {
            if (this.currentIndex == this.Capacity - 1)
            {
                IncreaseCapacity();
            }

            this.array[this.currentIndex+ 1] = element;
        }

        // Accessing element by index
        public T AccessElement(int index)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Index is out of range.");
            }

            T element = this.array[index];
            return element;
        }

        // Removing element by index
        public void RemoveElement(int index)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Index is out of range.");
            }

            for (int i = index; i < this.currentIndex + 1; i++)
            {
                array[i] = array[i + 1];
            }

            array[currentIndex] = default(T);
            this.currentIndex--;
        }
        
        // Inserting element at given position
        public void InsertElement(T element, int index)
        {
            if (index >= this.Capacity || index < 0)
            {
                throw new ArgumentOutOfRangeException(
                    "Index is out of range.");
            }

            if (this.currentIndex == this.Capacity - 1)
            {
                IncreaseCapacity();
            }

            for (int i = index; i < this.currentIndex + 1; i++)
            {
                array[i + 1] = array[i];
            }

            this.currentIndex++;
        }

        // Clearing the list
        public void ClearList()
        {
            for (int i = 0; i < this.currentIndex + 1; i++)
            {
                array[i] = default(T);
            }

            currentIndex = 0;
        }

        // Finding element index by given value
        public int FindElementIndex(T element)
        {
            int index = 0;
            for (int i = 0; i < this.currentIndex + 1; i++)
            {
                if (array[i].Equals(element))
                {
                    index = i;
                }
                else
                {
                    index = -1;
                }
            }
            
            return index;
        }
       
        // Printing the entire list
        public override string ToString()
        {
            T[] printList = array.ToArray();

            return string.Join(" ", printList);
        }

        private void IncreaseCapacity()
        {
            this.capacity = 2 * this.array.Length;
            T[] doubledList = new T[this.capacity];
            array.CopyTo(doubledList, 0);
        }
    }
}
