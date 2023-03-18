using Libraries;
namespace task052;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int mSize = 7;
        int nSize = 8;
        int leftRange = 0;
        int rightRange = 9;
        int[,] newIntArray = Library.GetRandomArray(mSize,nSize,leftRange,rightRange);

        // int[,] newIntArray = new int[,] {
        //     {1,4,7,2},
        //     {5,9,2,3},
        //     {8,4,2,4},
        // };
        Library.PrintArray(newIntArray);
        System.Console.WriteLine($"Average for every column is: {String.Join(", ", GetAverageOfColumns(newIntArray))}");

    }

    //calculating an average of every column in array and return as int[]
    static double[] GetAverageOfColumns(int[,] pArray)
    {
        System.Console.WriteLine($"x={pArray.GetLength(0)}; y={pArray.GetLength(1)}");
        double[] result = new double[pArray.GetLength(1)];
        for (int j = 0; j < pArray.GetLength(1); j++)
        {
            for (int i = 0; i < pArray.GetLength(0); i++)
            {
                result[j] += pArray[i, j];
            }
            result[j] = Math.Round(result[j]/(pArray.GetLength(0)),2);
        }

        return result;
    }
}
