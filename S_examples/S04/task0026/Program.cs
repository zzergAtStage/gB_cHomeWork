//using Libraries;
namespace task0026;
class Program
{
    // Задача 26: Напишите программу, которая принимает на вход число и 
    // выдаёт количество цифр в числе.
    // 456 -> 3
    // 78 -> 2
    // 89126 -> 5

    static void Main(string[] args)
    {
        Console.Clear();
        int number = int.Parse(Console.ReadLine());
        // int result = GetCountDigits(number);
        // Console.WriteLine($"Result GetCountDigits(task026) = {result}");
        //number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Result of multiplying of {number} is: {GetMultiplyAllDigits(number)}");
        

    }

    static int GetCountDigits(int number)
    {
        int counter = 0;
        int tmpInt = number;
        while (tmpInt != 0)
        {
            tmpInt = tmpInt / 10;
            counter = counter + 1;
        }

        return counter;
    }

    static int GetMultiplyAllDigits(int N){ // (1,N) 
        int result = 1;
        for (int i = 1; i <= N; i++ ){
            
            result = result * i; //1*2*3*4
        }
        
        return result;
    }


    
}
