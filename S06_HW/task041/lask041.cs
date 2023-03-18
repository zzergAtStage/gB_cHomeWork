using Libraries;
namespace task041;
class task041InputModes
{   //Задача 41: Пользователь вводит с клавиатуры M чисел. 
    //Посчитайте, сколько чисел больше 0 ввёл пользователь.
    // 0, 7, 8, -2, -2 -> 2
    // 1, -7, 567, 89, 223-> 3
    static void Main(string[] args)
    {
        Console.Clear();
        int arrSize = 0;
        //check input for size of array
        while(arrSize < 1){
         arrSize = Library.GetNumber("Input size of the new array (numbers > 0)");
        }
        int[] arrayInput = Library.GetArrayWithFixSize(arrSize, "Please enter the numbers for new array");
        //begin calc numbers
        int countOfPositiveMembers= 0;
        for (int i = 0; i < arrayInput.Length; i++)
        {
            if (arrayInput[i] > 0 ) countOfPositiveMembers++;
        }

        System.Console.WriteLine($"User had inputed {countOfPositiveMembers} positive numbers");
    }
}
