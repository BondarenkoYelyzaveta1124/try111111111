﻿using System;

namespace ConsoleApp10
{
    partial class Methods
    {
        public static void Olga1(bool isRandom) // Змінено на public
        {
            int[] array = isRandom ? ArrayRandom.GetArrayRandom() : ArrayHelper.GetArray(); // Отримуємо масив з `ArrayHelper`

            (int min, int max) = MinMax(array);
            int[] newArr = NewArray(array, min, max);

            PrintArray(newArr); // Виводимо оновлений масив
        }
        
        static (int min, int max) MinMax(int[] arr)
        {
            int min = arr[0], max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
            return (min, max);
        }
        static int[] NewArray(int[] arr, int min, int max)
        {
            int[] newArr = new int[arr.Length + 2];
            newArr[0] = min;
            Array.Copy(arr, 0, newArr, 1, arr.Length);
            newArr[newArr.Length - 1] = max;
            return newArr;
        }

        static void PrintArray(int[] arr)
        {
            Console.WriteLine("Оновлений масив:");
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
