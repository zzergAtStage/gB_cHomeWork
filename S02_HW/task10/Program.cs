namespace task10;
class Program
{
    static int GetInputInt(){
        int res = Random.Shared.Next(100,1000);
        //int 
        return res; 
    }
    static void Main(string[] args)
    {
//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
       Console.Clear();
       int number = GetInputInt();
       //получаем второе число
       int secondNum = ((number - (number % 10)) / 10) % 10;
       Console.WriteLine($" Number = {number}, second digit ={secondNum}");

    }
}
