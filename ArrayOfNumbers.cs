using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfNumbersApp
{
    internal class ArrayOfNumbers
    {
        private int[] numbers;

        public ArrayOfNumbers(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentOutOfRangeException("array size must be greater than zero");
            }

            numbers = new int[size];
        }

        public ArrayOfNumbers(int[] inputArray)
        {
            if (inputArray == null)
            {
                throw new ArgumentNullException("array cannot be null");
            }

            numbers = new int[inputArray.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = inputArray[i];
            }

        }

        public int GetElement(int index)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException("there is no such index");
            }
            return numbers[index];
        }

        public void SetElement(int index, int value)
        {
            if (index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException("there is no such index");
            }

            numbers[index] = value;

        }

        public int LargestNum()
        {
            if (numbers.Length == 0)
            {
                throw new InvalidOperationException("Array is empty.");
            }

            return numbers.Max();
        }

        public bool Equal(int index1, int index2)
        {
            return numbers[index1] == numbers[index2];
        }

        public int GCD(int index1, int index2)
        {
            int a = numbers[index1];
            int b = numbers[index2];

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }

        public int Count() 
        {
            return numbers.Length; 
        }

        public int Sum() 
        {
            return numbers.Sum(); 
        }

        public double Avg()
        {
            return Sum() / numbers.Length;
        }

        public override string ToString()
        {
            return "[" + string.Join(", ", numbers) + "]";
        }

    }
}
