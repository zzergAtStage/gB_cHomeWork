using Libraries;
namespace task001;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int leftRange = Library.GetInputFromUser("Input left range of natural numbers (m)");
        int rightRange = Library.GetInputFromUser("Input right range of natural numbers (N)");

        string result = OutputEvenNaturalNumbersToStoring(leftRange, rightRange);
        System.Console.WriteLine($" M,N = [{leftRange}],[{rightRange}] -> {result}");
    }
    static string OutputEvenNaturalNumbersToStoring(int pLeftRange, int pRightRange)
    {
        string tmpResult = String.Empty;
        if (pLeftRange >= pRightRange)
        {
            return tmpResult;
        }
        //pLeftRange++; why doesn't work increment in the methods call
        if (pLeftRange % 2 == 0)
        {
            if (pLeftRange == pRightRange) { //i hate non beautified output
                return tmpResult + $"{pLeftRange} {OutputEvenNaturalNumbersToStoring(pLeftRange, pRightRange)}";
            } else {
                return tmpResult + $"{pLeftRange}, {OutputEvenNaturalNumbersToStoring(pLeftRange, pRightRange)}";
            }
        }
        else
        {
            return OutputEvenNaturalNumbersToStoring(pLeftRange, pRightRange);
        }
    }
}
