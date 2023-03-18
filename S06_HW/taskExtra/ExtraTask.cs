using Libraries;
namespace task041;
class taskExtraInputModes
{
    static void Main(string[] args)
    {
        //задача от преподавателя)
// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
//  Ввод чисел останавливается при помощи ввода слова "stop"
        Console.Clear();
        int countOfPositiveMembers = 0;
        string inputS = "";
        bool proceed = true;
        while (proceed)
        {
            inputS = Library.GetInputFromUser("Input a number");//по хорошему, в либе нужно добавить проверку на ввод числа.
            if (inputS.ToUpper() != "STOP") {
                int number = int.Parse(inputS);// но с учетом работы со сторокой, лучше бы тут добавить exception
                if (number > 0) countOfPositiveMembers++;
            } else {
                proceed = false;
            }
        }
        System.Console.WriteLine($"User had inputted {countOfPositiveMembers} positive numbers");
    }
}
