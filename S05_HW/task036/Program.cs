using Libraries;
namespace task036;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int arraySize = 7;
        int leftRange = -100;
        int rightRange = 100;

        int[] arrayRandom = Libraries.Library.GetRandomArray(arraySize, leftRange, rightRange);
        Libraries.Library.PrintArray(arrayRandom);
        System.Console.WriteLine($"Summ of odd position numbers: {GetSummOfOddPositionNumbers(arrayRandom)}");
    }

    static int GetSummOfOddPositionNumbers(int[] pArray)
    {
        int oddPositionNumbersSumm = 0;
        int iDx = 1;
        while (iDx < pArray.Length)
        {
            oddPositionNumbersSumm += pArray[iDx];
            iDx += 2;
        }
        return oddPositionNumbersSumm;
    }
}
