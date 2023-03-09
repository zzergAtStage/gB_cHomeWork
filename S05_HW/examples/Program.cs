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

        int arraySize = 12;
        int[] arrayToRevere = new int[] {-4, -8, 8, 2};
        Library.PrintArray(arrayToRevere);
        ReversIntArray(ref arrayToRevere);
        System.Console.WriteLine();
        Library.PrintArray(arrayToRevere);

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

    static void ReversIntArray(ref int[] pArray){
        for (int i = 0; i < pArray.Length; i++)
        {
            pArray[i] *= -1;
        }
    }
}
