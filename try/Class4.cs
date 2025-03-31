using System;

public class FillArray
{
    private static int[] array;

    public static void SetArray(int[] newArray)
    {
        array = newArray;
    }

    public static int[] GetArray()
    {
        return array;
    }

    public static void PrintArray()
    {
        if (array == null)
        {
            Console.WriteLine("Массив не задан!");
            return;
        }

        Console.WriteLine("Текущий массив: " + string.Join(", ", array));
    }


    public static void InputArray()
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());
        int[] array = new int[size];

        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i < size; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        SetArray(array);
        Console.WriteLine("Массив сохранён!");
    }

    public static void ProcessArray()
    {
        int[] array = GetArray();
        if (array == null)
        {
            Console.WriteLine("Массив не задан! Введите данные сначала.");
            return;
        }

        Console.WriteLine("Обработка массива...");
        // Здесь можно что-то делать с массивом
    }
}
