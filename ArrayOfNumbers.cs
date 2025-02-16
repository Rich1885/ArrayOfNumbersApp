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
            if(size <= 0)
            {
                throw new ArgumentOutOfRangeException("array size must be greater than zero");
            }

            numbers = new int[size];
        }

        public ArrayOfNumbers(int[] inputArray)
        {
            if(inputArray == null)
            {
                throw new ArgumentNullException("array cannot be null");
            }

            numbers = new int[inputArray.Length];

            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = inputArray[i];
            }

        }

        public int GetElement(int index) 
        {
            if(index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException("there is no such index");
            }
            return numbers[index];
        }

        public void SetElement(int index, int value)
        {
            if(index < 0 || index >= numbers.Length)
            {
                throw new IndexOutOfRangeException("there is no such index");
            }

            numbers[index] = value;

        }
    }
}
