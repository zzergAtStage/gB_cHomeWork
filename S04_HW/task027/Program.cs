// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

class task027
{
    
    static int  CalcSumOfDigits(int number){
        int sum = 0;
        while (number > 0) {
            sum = sum + (number % 10);
            number /= 10;
        }
        return sum;
    }
    
    public static void Main(string[] args){
        
        Console.Clear();
        Console.Write("Input number to calculate the summ of its digits:");
        int number = int.Parse(Console.ReadLine())!;
        int numToSum = CalcSumOfDigits(number);
        Console.WriteLine($" Result of {number} -> {numToSum}");
    }
}