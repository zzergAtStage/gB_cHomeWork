
namespace S07;
class Program
{

    //     Задача 48: Задайте двумерный массив размера m на n
    //, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
    // m = 3, n = 4.
    // 0 1 2 3
    // 1 2 3 4
    // 2 3 4 5

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
        //вывод на экран
       PrintArray(arrayInt);
    }

    static void PrintArray(int[,] pArray){
        for (int i = 0; i < pArray.GetLength(0); i++)
        {
            for (int j = 0; j < pArray.GetLength(1); j++)
            {
               Console.Write($"{pArray[i,j]} ");
            }
            System.Console.WriteLine();
        }
    }
}
