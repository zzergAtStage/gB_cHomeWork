// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
namespace task029;
class Program
{
    public static int[]  GetNumbers(int countNums){
        int[] inputNumArr = new int[countNums];
        for (int i = 0; i < countNums; i++)
        {
            Console.Write($"Input elent #{i+1}:");
            inputNumArr[i] = int.Parse(Console.ReadLine()!);
        }
        return inputNumArr;
    }
    public static void PrintArray(int[] arr){
            
            Console.Write($"[{String.Join(",",arr)}]");
        
    }

    public static void Main(string[] args){
        Console.Clear();
        
        int arrSize = int.Parse(Console.ReadLine()!);
        int[] inpArr = GetNumbers(8);
        PrintArray(inpArr);
    }

}

    