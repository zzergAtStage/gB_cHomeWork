using Libraries;
namespace task043;
class Program
{
    //Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
    //заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
    //b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
    static void Main(string[] args)
    {
        double getPos(double b1, double k1, double b2, double k2, double x = 0)
        {
          // System.Console.WriteLine($"Debug: posX={x}, b1={b1}, k1={k1},b2={b2},k2={k2}");
           if (x == 0)
            {
                double posX = 0;
                posX = (b2 - b1) / (k1 - k2);
              //  System.Console.WriteLine($"Debug: posX={posX}");
                return posX;
            }
            else
            {
                return k1 * x + b1;
            }
        }
        // 
        //y = k1 * x + b1, y = k2 * x + b2
        //k1*x+b1 = k2*x+b2
        //k1*x-k2*x = b2 - b1
        //(k1 - k2)*x = b2 - b1
        //x = (b2-b1)/ (k1 - k2)
        Console.Clear();
        double b1 = 2, k1 = 5, b2 = 4, k2 = 9;
        
        if ((b2 == 0 && b1 == 0) || (k1 == k2))
        {
            System.Console.WriteLine("Straight lineы are parallel!");
            Environment.Exit(0);
        }
        double posX = 0;
        double posY = 0;
        posX = getPos(b1, k1, b2, k2, posX);
        posY = getPos(b1, k1, b2, k2, posX);

        System.Console.WriteLine($" point of intersection of straight lines is ({posX},{posY})");


    }
}
