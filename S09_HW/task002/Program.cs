
using Libraries;
namespace task002;
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        int M = Library.GetNumber("Input number M");
        int N = Library.GetNumber("Input number N");
        System.Console.WriteLine($"Thu sum of natural numbers between M({M}) and N({N}) is:");
        System.Console.WriteLine($"{GetSumNaturalNumbers(M,N)}");

        int GetSumNaturalNumbers(int pM, int pN){
            if (pM > pN) return 0;
            else return pN + GetSumNaturalNumbers(pM, pN -1);
        }
    }
}
