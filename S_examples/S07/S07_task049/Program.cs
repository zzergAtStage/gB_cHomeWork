namespace S07_task049;
class Program
{
    //Задача 49: Задайте двумерный массив. Найдите элементы
    //, у которых оба индекса чётные, и замените эти элементы на их квадраты.

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
        System.Console.WriteLine("Powering...");
        //возводим в степень
        for (int i = 1; i < arrayInt.GetLength(0); i+=2)
        {
            for (int j = 1; j < arrayInt.GetLength(1); j+=2)
            {
                arrayInt[i, j] *= arrayInt[i, j];//(int)Math.Pow(arrayInt[i, j],2) ;
            }
        }
        PrintArray(arrayInt);

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
