namespace task019;
class task019
{
    static void Main(string[] args)
    {
//Задача 19.Напишите программу, которая принимает на 
//вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
        const int LEFTRANGE = 9999;
        const int RIGTHRANGE = 99999;
        const int DECIMALDIVIDER = 10;
        static bool doCheckIntForPolindromic(int checkedValue){
            int decimalDecrieser = 10000, tmpVaule = checkedValue, reversedValue = 0;
            while (tmpVaule > 0)
            { //отщипываем последнее число через %, и превращаем в первый знак
                reversedValue += (tmpVaule % DECIMALDIVIDER) * decimalDecrieser;
                tmpVaule /= DECIMALDIVIDER;
                decimalDecrieser /= 10;
            }
            return (checkedValue == reversedValue);
        }
 
        Console.Clear();
        System.Console.Write("Please, put 5th digit number: ");
        int originalValue = int.Parse(Console.ReadLine());
        if (originalValue < LEFTRANGE  || originalValue  > RIGTHRANGE){
            Console.WriteLine($"Input must be an 5th digits (now ->{originalValue})");
            Environment.Exit(0);
        }
        System.Console.WriteLine($"Input ({originalValue}) is Polindromic -> {doCheckIntForPolindromic(originalValue)}");

    }
}
