// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

public class Task025
{
    
    public static int[]  GetNumbers(int countNums){
        int[] inputNumArr = new int[countNums];
        for (int i = 0; i < countNums; i++)
        {
            Console.WriteLine($"Введите число{i+1}");
            inputNumArr[i] = int.Parse(Console.ReadLine());
        }
        return inputNumArr;
    }
    
    
    
    public static void Main(string[] args){
        Console.Clear();
        int[] ArrNumbers = Task025.GetNumbers(2);
        double res = Math.Pow(ArrNumbers[0],ArrNumbers[1]);//так как условия задачи фиксированы, хардкод
        Console.WriteLine($"{ArrNumbers[0]}, {ArrNumbers[1]} -> {res}");
    }
}