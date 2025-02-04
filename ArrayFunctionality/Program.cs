using System;
namespace ArrayFunctionality
{
    class Program
    {
        public static void inputInArray(ref int[] array)
        {
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < array.Length; i++)
                int.TryParse(Console.ReadLine(), out array[i]);
        }
        public static void printArray(int[] array)
        {
            Console.WriteLine("Array: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

        }
        static void Main()
        {
            Console.WriteLine("Enter Array Size: ");
            int arrayLength;
            if (!int.TryParse(Console.ReadLine(), out arrayLength))
                Console.WriteLine("Enter valid integer value");
            int[] array = new int[arrayLength];

            inputInArray(ref array);
            printArray(array);
        }
    }
}
