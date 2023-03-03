using Libraries;
namespace task021;
class task021
{
//      PS. Так как задачу уже решал с другой группой, решил извратиться с оформлением 
// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
// Формула нахождения длины отрезка в 3х мерном пространстве:
// AB = sqrt((xB - xA) ^ 2 + (yB - yA) ^ 2 + (zB - zA) ^ 2)
    static Dictionary<string, double> Coordinates = new Dictionary<string, double>();
    static void Main(string[] args)
    {   
        Coordinates.Add("xA",0);
        Coordinates.Add("yA",0);
        Coordinates.Add("zA",0);
        Coordinates.Add("xB",0);
        Coordinates.Add("yB",0);
        Coordinates.Add("zB",0);        
        static void  GetVectorCoordinates(){
            Console.Clear();
            foreach (var item in Coordinates)
            {
                Coordinates[item.Key] = Libraries.Library.GetInputIntNumber(0
                                ,false
                                ,$"Input coordinate {item.Key}: ");
            }
        }
        static double CalcVectorLength(){
            return Math.Sqrt(Math.Pow((Coordinates["xB"] - Coordinates["xA"]),2)
                    + Math.Pow((Coordinates["yB"] - Coordinates["yA"]),2)
                    + Math.Pow((Coordinates["zB"] - Coordinates["zA"]),2)
                    );
        }
        static string PrintVectorValues(){
            string value = $"({Coordinates["xA"]},{Coordinates["yA"]},{Coordinates["zA"]})," + 
                                $"({Coordinates["xB"]},{Coordinates["yB"]},{Coordinates["zB"]})";
            return value;
        }
        Console.Clear();       
        GetVectorCoordinates();
        System.Console.WriteLine($"The length of AB{PrintVectorValues()} -> {Math.Round(CalcVectorLength(),2)}"); 
    }
}
