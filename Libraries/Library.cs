namespace Libraries;

public class Library
{

    public static double[] GetRandomRealArray(int length, double leftRange, double rigthRange)
    {
        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Math.Round((Random.Shared.NextDouble() * (rigthRange - leftRange) + leftRange), 2);
        }

        return arr;
    }
    public static int[] GetRandomArray(int length, int leftRange, int rigthRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rigthRange);
        }

        return arr;
    }
    public static (int, int) SumPositiveAndNegotiveElements(int[] arr)
    {
        int sumPositive = 0; //summ of positive elements of array
        int sumNegative = 0; //summ of negative elements of array

        foreach (int num in arr)
        {
            if (num > 0)
            {
                sumPositive += num;
            }
            else
            {
                sumNegative += num;
            }
        }
        return (sumNegative, sumPositive);
    }
    public static void PrintArray(double[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }

    public static int GetIndexOfMinimalArrayMember(double[] array)
    {
        double min = array[0];
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
            {
                min = array[i];
                minIndex = i;
                // Console.WriteLine($" minIndex = {minIndex}; i={i}; min={min}");
            }
        }
        return minIndex;
    }
    public static int GetIndexOfMaximalArrayMember(double[] array)
    {
        double max = array[0];
        int maxIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
                // Console.WriteLine($" maxIndex = {maxIndex}; i={i}; max={max}");
            }
        }
        return maxIndex;
    }
    public static int GetCountOfDigits(int tstNumber, int leftRange = 0){
        int CountOfDigits = -1;
        int i = 1;
        for (; tstNumber > leftRange ; i++)
        {
            tstNumber /= 10;
            //System.Console.WriteLine($".GetCountOfDigits = {tstNumber}");
            CountOfDigits = i;
        }
        return CountOfDigits;
    }
    
    public static int getDigitByPosition(int value, int inrow)
    {
        // вычисляем на сколько разрядов поделить исходное, что бы получить нужное
        //0 - 1ый разряд
        // ..
        //2 - 3ий и т.д.
        int p = (int)Math.Pow(10, inrow);
        value = value / p;
        return (value % 10);
    }

    /**
       Method calcs a summ of digit in Decimal <paramref name="number"/>
    */
    public static int CalcSumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum = sum + (number % 10);
            number /= 10;
        }
        return sum ;
    }
    public static int GetInputIntNumber(int numberOfDigit
                        , bool doCheck = false
                        , string message = "Input integer:")
    {
        int result = 0;
        string resultS;
        if (numberOfDigit == 0) {
            Console.Write($"{message}");
        } else {
            Console.Write($"{message} with {numberOfDigit} digits: ");
        }

        if (doCheck)
        {

            bool goAcross = true;
            while (goAcross)
            {
                resultS = Console.ReadLine()!;
                if (String.IsNullOrEmpty(resultS))
                {
                    System.Console.WriteLine("Input of blank lines not allowed! Repeat your input...");
                    goAcross = true;
                    continue;
                }
                goAcross = false;
                result = int.Parse(resultS);
            }
            

        }
        else
        {
            result = int.Parse(Console.ReadLine()!);
        }
        int tmp = GetCountOfDigits(result);
        if (tmp != numberOfDigit && numberOfDigit != 0)
        {
            System.Console.WriteLine($"Try to input number with {numberOfDigit} digits, please! Now = {tmp}, Result={result}");
            result = GetInputIntNumber(numberOfDigit, false);
        }

        return result;
    }
}
