using Libraries;
namespace task047;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        //задаем двумерный массив с вещественными числами
        int m = Library.GetNumber("Input array's side m");
        int n = Library.GetNumber("Input array's side n");

        double[,] naturalNumbersArray = Library.GetRandomRealArray(m, n, -100, 100);
        Library.PrintArray(naturalNumbersArray);
    }
}
