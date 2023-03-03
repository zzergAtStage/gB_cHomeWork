namespace task023;
class Program
{
    static int num = 0;
    static void Main(string[] args)
    {
        // Задача 23
        // Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
        // 3 -> 1, 8, 27
        // 5 -> 1, 8, 27, 64, 125
        Console.Clear();
        Program mathElement = new Program();
        Console.Write("Inpit number:");
        num = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{num} ->");
        double[] thirdPowered = new double[num];
        thirdPowered = GetPowForArray();
        Libraries.Library.PrintArray(thirdPowered);


        static double[] GetPowForArray()
        {
            double[] arrayToPow = new double[num];
            for (int i = 1; i <= num; i++)
            {
                arrayToPow[i-1] = Math.Pow(i, 3);
            }
            return arrayToPow;
        }
    }
}
