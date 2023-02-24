namespace task004;
class Program
{
    public static int GetInputNumber(string promptMessage)
    {
        Console.Write(promptMessage + ": ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
    static void Main(string[] args)
    {
//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
        Console.Clear();
        int value = GetInputNumber("Input a number ");
        Console.WriteLine("Even numbers:");
        string? val = null;
        for (int i = 2; i <= value; i +=2)
        {
            if (i%2 == 0) {
                val += i.ToString() + ", ";
            }
        }
        Console.WriteLine($" {value} -> {val}");
    }
}
