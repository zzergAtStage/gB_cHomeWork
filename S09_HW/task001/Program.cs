using Libraries;
namespace task001;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int leftRange = Library.GetInputFromUser("Input left range of natural numbers (m)");
        int rightRange = Library.GetInputFromUser("Input right range of natural numbers (N)");

        string result = GetEvenNaturalNumbersToStoring(leftRange, rightRange);
        System.Console.WriteLine($" M,N = [{leftRange}],[{rightRange}] -> {result}");
    }
    static string GetEvenNaturalNumbersToStoring(int pLeftRange, int pRightRange)
    {
        string tmpResult = String.Empty;
        System.Console.Write($"L={pLeftRange}=>");
        if (pLeftRange >= pRightRange) return tmpResult;


        if (pLeftRange % 2 == 0)
        {
            Environment.Exit(0);
            System.Console.Write($"L={pLeftRange}=>");
            return $"{tmpResult}, {GetEvenNaturalNumbersToStoring(pLeftRange++, pRightRange)}";
            
        }
        else
        {   
            System.Console.Write($"L={pLeftRange}=>");
            Environment.Exit(0);
            return GetEvenNaturalNumbersToStoring(pLeftRange++, pRightRange);
            
        }
    }
}
