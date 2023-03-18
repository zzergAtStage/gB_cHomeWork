namespace S07_task051;
class Program
{
    //Задача 51: Задайте двумерный массив. Найдите сумму элементов
    //, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

    static void Main(string[] args)
    {
       Console.Clear();
        System.Console.WriteLine($"Input size (M):");
        int M = int.Parse(Console.ReadLine());
        System.Console.WriteLine($"Input size (N):");
        int N = int.Parse(Console.ReadLine());
        int[,] arrayInt = new int[M, N];
        for (int i = 0; i < arrayInt.GetLength(0); i++)
        {
            for (int j = 0; j < arrayInt.GetLength(1); j++)
            {
                arrayInt[i, j] = i + j;
            }
        }
        PrintArray(arrayInt);
        int summDiag = 0;
        int minLength = Math.Min(arrayInt.GetLength(0),arrayInt.GetLength(1));
        
        for (int i = 0; i < minLength; i++)
        {
           summDiag +=  arrayInt[i,i];
        }

        System.Console.WriteLine($"Sum of diagonal is: {summDiag} ");
    }
     static void PrintArray(int[,] pArray)
    {
        for (int i = 0; i < pArray.GetLength(0); i++)
        {
            for (int j = 0; j < pArray.GetLength(1); j++)
            {
                Console.Write($"{pArray[i, j]} ");
            }
            System.Console.WriteLine();
        }
    }
}
