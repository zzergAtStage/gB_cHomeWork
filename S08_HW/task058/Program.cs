using Libraries;
namespace task058;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int leftRange = 1;
        int rightRange = 10;
        int sideSize = Library.GetNumber("Input size of matrix = ");

        int[,] arrayFirst = Library.GetRandomArray(sideSize, sideSize, leftRange, rightRange);
        int[,] arraySecond = Library.GetRandomArray(sideSize, sideSize, leftRange, rightRange);
        Library.PrintArray(arrayFirst);
        Library.PrintArray(arraySecond);
        int[,] resultArray = Multiplay(ref arrayFirst, ref arraySecond);
        Library.PrintArray(resultArray);
    }

    static int[,] Multiplay(ref int[,] pArrayFirst, ref int[,] pArraySecond)
    {
        int sideSize = pArrayFirst.GetLength(0);
        int[,] resultArray = new int[sideSize, sideSize];

        for (int i = 0; i < sideSize; i++)
        {
            for (int j = 0; j < sideSize; j++)
            {
                for (int k = 0; k < sideSize; k++)
                {
                   
                    resultArray[i, j] += pArrayFirst[i,k] * pArraySecond[k, j] ;
                    //  System.Console.WriteLine($"resultArray[{i}, {j}] = {resultArray[i, j]}; pArrayFirst[{i},{k}]={pArrayFirst[i,k]} " 
                    //  + $"pArraySecond[{k}, {j}]={pArraySecond[k, j]}");
                     
                }
                
            }

        }
        return resultArray;
    }
    
}
