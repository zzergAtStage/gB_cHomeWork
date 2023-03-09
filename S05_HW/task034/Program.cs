namespace task034;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int arraySize = 5;
        int leftRange = 100;
        int rightRange = 999;
        int[] arrayThreeDigits = Libraries.Library.GetRandomArray(arraySize, leftRange, rightRange);
        Libraries.Library.PrintArray(arrayThreeDigits);
        Console.WriteLine($"The odd numbers amount: {GetOddNumbersCount(arrayThreeDigits)}");
    }

    static int GetOddNumbersCount(int[] pArray)
    {
        int evenNumsCount = 0;
        for (int i = 0; i < pArray.Length; i++)
        {
            if (pArray[i] % 2 == 0) evenNumsCount++;
        }
        return evenNumsCount;
    }
}
