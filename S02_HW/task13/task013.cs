using Libraries;
namespace task13;
class task013
{
    static void Main(string[] args)
    {
    //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    // 645 -> 5
    // 78 -> третьей цифры нет
    // 32679 -> 6    
        Console.Clear();
        int number = Library.GetInputIntNumber(0,false);
       
        if (number < 100) {
            System.Console.WriteLine($" There is no Third digit by [{number}]");
        } else {
            int res = Library.getDigitByPosition(number,0);//функция реализована НЕ ЧЕРЕЗ МАССИВ
            System.Console.WriteLine($" Third digit of [{number}] -> {res}");
        }
    }
}
