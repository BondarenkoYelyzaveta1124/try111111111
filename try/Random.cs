using System;
using System.Threading.Tasks.Dataflow;

namespace ConsoleApp10
{
    public static class ArrayRandom
    {
        private static int[] arrayRandom; // Масив випадкових чисел

        public static void InputArrayRandom()
        {
            Console.Write("Введіть, скільки елементів згенерувати випадково: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rand.Next(-1000000, 1000000);
            }

            arrayRandom = arr;
            Console.WriteLine("Згенерований масив: " + string.Join(" ", arr));
            Console.WriteLine("Масив успішно збережений!");

        }

        public static int[] GetArrayRandom()
        {
            return arrayRandom ?? new int[0]; // Якщо масив ще не задано, повертаємо порожній
        }

        public static void ClearArray()
        {
            arrayRandom = new int[0]; // Очищаємо масив
        }
    }
}
