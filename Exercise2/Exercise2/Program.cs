using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] NumbersArray = new int[] { 1, 23, 4 };
            NumbersArray = UtilityClass<int>.Swap(NumbersArray, 0, 2);
            Console.WriteLine(String.Join(" ", NumbersArray));

            string[] ColorsArray = new string[] { "red", "green", "blue" };
            ColorsArray = UtilityClass<string>.Swap(ColorsArray, 0, 2);
            Console.WriteLine(String.Join(" ", ColorsArray));
        }
    }

    class UtilityClass<T>
    {
        public static T[] Swap(T[] array, int firstElemIndex, int secondElemIndex)
        {
            if((firstElemIndex > array.Length - 1 || firstElemIndex < 0) ||
                (secondElemIndex > array.Length - 1 || secondElemIndex < 0))
            {
                Console.WriteLine("Invalid indexes passed.");
            }
            else
            {
                T temporary = array[firstElemIndex];
                array[firstElemIndex] = array[secondElemIndex];
                array[secondElemIndex] = temporary;
            }

            return array;
        }


    }
}
