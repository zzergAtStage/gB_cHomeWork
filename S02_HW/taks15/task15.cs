//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

using Libraries;
namespace taks15;
class taks15
{
    static void Main(string[] args)
    {
      Console.Clear();
      int dayOfWeek = Library.GetInputIntNumber(1,true, "Day of week:");
      if (dayOfWeek == 6 || dayOfWeek == 7) {
        System.Console.WriteLine($" {dayOfWeek} -> Yes");
      }  else
      {
        System.Console.WriteLine($" {dayOfWeek} -> No");
      }
    }
}
