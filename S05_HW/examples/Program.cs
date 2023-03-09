using Libraries;
namespace examples;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //task031
        // int leftRange = -9; //declarations
        // int rightRange = 9;
        // int arraySize = 12;

        
        // int[] positiveAndNegativeArray = Library.GetRandomArray(arraySize, leftRange, rightRange);
        // Library.PrintArray(positiveAndNegativeArray);
        // Console.WriteLine($"Summa of positive elements: {GetSumPositiveMembers(positiveAndNegativeArray)}");
        // Console.WriteLine($"Summa of negative elements: {GetSumNegativeMembers(positiveAndNegativeArray)}");
        // Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
        //соответствующие отрицательные, и наоборот.
        // [-4, -8, 8, 2] -> [4, 8, -8, -2] 

        //task031

        //int arraySize = 12;
        // int[] arrayToRevere = new int[] {-4, -8, 8, 2};
        // Library.PrintArray(arrayToRevere);
        // ReversIntArray(ref arrayToRevere);
        // Console.WriteLine();
        // Library.PrintArray(arrayToRevere);

        // Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
        // 4; массив [6, 7, 19, 345, 3] -> нет
        // -3; массив [6, 7, 19, 345, 3] -> да
        // System.Console.WriteLine("Input searched number:");
        // int searchNumber = int.Parse(Console.ReadLine()!);
        // int[] arrayToSearch = new int[] {6, 7, 19, 345, 3};
        // Library.PrintArray(arrayToSearch);
        // System.Console.Write($" -> {IsNumberInArray(arrayToSearch,searchNumber )}");

        // Задача 35: Задайте одномерный массив из 123 случайных чисел. 
        // Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
        // Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
        // [5, 18, 123, 6, 2] -> 1
        // [1, 2, 3, 6, 2] -> 0
        // [10, 11, 12, 13, 14] -> 5
        // int arraySize = 123;
        // int[] arrayToSearch = Library.GetRandomArray(arraySize,0,123);
        // //int[] arrayToSearch = new int[] {5, 18, 123, 6, 2};
        // Library.PrintArray(arrayToSearch);
        // int count = 0;

        // for (int i = 0; i < arrayToSearch.Length; i++)
        // {
        //     if (arrayToSearch[i] >= 10 && arrayToSearch[i] <=99) count++;
        // }
        // System.Console.WriteLine($"In array we've found: {count} elements between 10 and 99");

        //   Задача 37: Найдите произведение пар чисел в одномерном массиве. 
        // Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
        // [1 2 3 4 5] -> 5 8 3
        // [6 7 3 6] -> 36 21
        // for (int i = 0; i < length/2; i++)
        // {
        //     Array[i] + Array[length -1 - i]
        // }


    }

    //methods
    static int GetSumPositiveMembers(int[] pArray)
    {
        int arraySize = pArray.Length;
        int positiveSumm = 0;
        for (int i = 0; i < arraySize; i++)
        {
            if (pArray[i] >= 0) positiveSumm += pArray[i];
        }

        return positiveSumm;

    }
    static int GetSumNegativeMembers(int[] pArray)
    {
        int arraySize = pArray.Length;
        int negativeSumm = 0;

        for (int i = 0; i < arraySize; i++)
        {
            if (pArray[i] < 0)
            {
                negativeSumm += pArray[i];
            }
        }
        return negativeSumm;
    }
    static int[] GetRandomArray(int length, int leftRange, int rigthRange)
        {
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = Random.Shared.Next(leftRange, rigthRange);
            }

            return arr;
        }
    static void ReversIntArray(ref int[] pArray){
        for (int i = 0; i < pArray.Length; i++)
        {
            pArray[i] = pArray[i] * -1;
        }
    }

    static bool IsNumberInArray(int[] pArray, int searchNumber){
        bool result = false;
        for (int i = 0; i < pArray.Length; i++)
        {
            if (pArray[i] == searchNumber){ return true;}
        }
        return result;
    }
}
