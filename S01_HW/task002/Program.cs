class task002
{   //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
    // 2, 3, 7 -> 7
    // 44 5 78 -> 78
    // 22 3 9 -> 22
    public static int GetInputNumber(string promptMessage)
    {
        Console.Write(promptMessage + ": ");
        int value = Convert.ToInt32(Console.ReadLine());
        return value;
    }

    static void Main(string[] args)
    {
        int a = task002.GetInputNumber("Input value for a ");
        int b = GetInputNumber("Input value for b ");
        int c = GetInputNumber("Input value for c ");
        int max = a; // так как мы не в массиве - сравниваем каждую из переменных
        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }
        Console.WriteLine($" Max of {a}, {b}, {c} -> {max}");
    }


}
