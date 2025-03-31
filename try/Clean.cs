using System;

namespace ConsoleApp10
{
    public static class ArrayClear
    {
        public static void ClearAll()
        {
            ArrayHelper.ClearArray(); 
            ArrayRandom.ClearArray(); 

            Console.WriteLine("Масив успішно очищен!");
        }
    }
}
