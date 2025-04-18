﻿using System;

namespace ConsoleApp10
{
    public static class ArrayHelper
    {
        private static int[] array;
        public static void InputArray()
        {
            Console.WriteLine("Введіть елементи масиву через пробіл:");
            string input = Console.ReadLine();
            array = ParseArray(input);
            if (array.Length > 0)
            {
                Console.WriteLine("Масив успішно збережений!");
            }
        }
        private static int[] ParseArray(string input)
        {
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = new int[parts.Length];

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    Console.WriteLine($"Помилка: '{parts[i]}' не є коректним цілим числом.");
                    return new int[0];
                }
            }
            return arr;
        }
        public static int[] GetArray()
        {
            return array ?? new int[0];
        }
        public static void ClearArrayRandom()
        {
            array = null;
        }
    }
}