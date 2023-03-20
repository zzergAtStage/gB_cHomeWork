using Libraries;
namespace task056;
class Program
{
    static void Main(string[] args)
    {
        int arraySize = 4;
        int leftRange = 0;
        int rightRange = 99;
        int[,] randomArray = Library.GetRandomArray(arraySize, arraySize, leftRange, rightRange);
        Console.Clear();
        Library.PrintArray(randomArray);

        //calc row with minimal sum of elements
        int currMinimalRow = 0;
        int minimalSum = 0;
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            int tmpSum = 0;
            for (int j = 0; j < randomArray.GetLength(1); j++)
            {
                tmpSum += randomArray[i,j];
            }
            System.Console.WriteLine($"tmpSum = {tmpSum}");
            if (i==0) minimalSum = tmpSum;
            if (tmpSum <= minimalSum && i != 0) {
                minimalSum = tmpSum;
                currMinimalRow = i;
            }
        }

        System.Console.WriteLine($" Minimal sum ={minimalSum} with row:[{currMinimalRow}]");

    }
}
