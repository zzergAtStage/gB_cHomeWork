
class task003
{
    public static int GetInputNumber(string promptMessage)
    {
        Console.Write(promptMessage + ": ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }
    static void Main(string[] args)
    {
       // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        // 4 -> да
        // -3 -> нет
        // 7 -> нет
        Console.Clear();
        int value = GetInputNumber("Input value to check even number ");
        if (value %2 == 0) {
            Console.WriteLine($"Value {value} is even!");
        } else {
            Console.WriteLine($"Value {value} is Odd!");
        }
    }
}
