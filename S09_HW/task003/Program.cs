using Libraries;
namespace task003;
class Program
{
    static void Main(string[] args)
    {

        Console.Clear();
        double m = Library.GetNumber("Input number m");
        double n = Library.GetNumber("Input number n");
        System.Console.WriteLine($"Akkerman number is: {GetAkkermanNumber(m, n)}");
        
        //implementation
        double GetAkkermanNumber(double m, double n)
        {
            //brain burn function =(
            if (m == 0)
            {
                return n + 1;
            }
            else if (n == 0)
            {
                return GetAkkermanNumber(m - 1, 1);
            }
            else
            {
                return GetAkkermanNumber(m - 1, GetAkkermanNumber(m, n - 1));
            }
        }
    }
}