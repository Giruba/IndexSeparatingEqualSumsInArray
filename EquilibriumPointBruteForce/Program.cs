using System;

namespace EquilibriumPointBruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Equilibrium Point in an array!");
            Console.WriteLine("------------------------------");

            try
            {
                int[] array = GetArrayFromInput();
                int equilibiriumPoint = GetEquilibriumPoint(array);
                if (equilibiriumPoint != -1)
                {
                    Console.WriteLine("The equilibrium point in the array is " + equilibiriumPoint);
                }
                else {
                    Console.WriteLine("There is no equilibrium point in the array");
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            Console.ReadLine();
        }

        private static int[] GetArrayFromInput() {
            int[] array = null;

            Console.WriteLine("Enter the number of elements in the array");
            try
            {
                int noElements = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the elements separated by space");
                String[] elements = Console.ReadLine().Split(' ');
                array = new int[noElements];
                for (int index = 0; index < noElements; index++) {
                    array[index] = int.Parse(elements[index]);
                }
            }
            catch (Exception exception) {
                Console.WriteLine("Thrown exception is "+exception.Message);
            }


            return array;
        }

        private static int GetEquilibriumPoint(int[] array) {
            int result = -1;

            if (array.Length == 1) {
                return array[0];
            }

            for (int index = 1; index < array.Length; index++) {
                int firstHalfSum = 0;
                int secondHalfSum = 0;
                for (int firstIndex = 0; firstIndex < index; firstIndex++) {
                    firstHalfSum += array[firstIndex];
                }

                for (int secondIndex = index+1; secondIndex < array.Length; secondIndex++)
                {
                    secondHalfSum += array[secondIndex];
                }

                if (firstHalfSum == secondHalfSum) {
                    return index;
                }
            }

            return result;
        }
    }
}
