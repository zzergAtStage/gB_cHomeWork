
namespace task030;
class Program
{
    static void Main(string[] args)
    {
        int[] array = GetRandomArray(10, 1, 10);
        PrintArray(array);
        int searchedNumber = 3;
        bool result = IsNumberArrayMember(array, searchedNumber);
        Console.WriteLine($" result = {result}");
    }

    static bool IsNumberArrayMember(int[] array, int number)
    {
        //foreach (int tmpNumber in array)
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number) return true;
        }
        return false;
    }

    static int[] GetRandomArray(int length, int leftRange, int rigthRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rigthRange);
        }

        return arr;
    }
    static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
}
