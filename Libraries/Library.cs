namespace Libraries;

public class Library
{
    //input one integer with prompt
    public static int GetNumber(string prompt = "")
    {
        System.Console.Write($"{prompt}: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    //getting a dynamic variable to make an 41th task
    public static dynamic GetInputFromUser(string prompt)
    {
        Console.Write(prompt + " ");
        string input = Console.ReadLine();

        int intValue;
        if (int.TryParse(input, out intValue))
        {
            return intValue;
        }

        double doubleValue;
        if (double.TryParse(input, out doubleValue))
        {
            return doubleValue;
        }

        return input;
    }


    public static double[] GetRandomRealArray(int length, double leftRange, double rightRange)
    {
        double[] arr = new double[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Math.Round((Random.Shared.NextDouble() * (rightRange - leftRange) + leftRange), 2);
        }

        return arr;
    }
    //two dimension array
    public static double[,] GetRandomRealArray(int length, int hight, double leftRange, double rightRange)
    {
        double[,] arr = new double[length,hight];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < hight; j++)
            {
              arr[i,j] = Math.Round((Random.Shared.NextDouble() * (rightRange - leftRange) + leftRange), 2);  
            }
            
        }

        return arr;
    }

    public static int[] GetRandomArray(int length, int leftRange, int rightRange)
    {
        int[] arr = new int[length];
        for (int i = 0; i < length; i++)
        {
            arr[i] = Random.Shared.Next(leftRange, rightRange);
        }

        return arr;
    }

     public static int[,] GetRandomArray(int length, int hight, int leftRange, int rightRange)
    {
        int[,] arr = new int[length,hight];
        for (int i = 0; i < length; i++)
        {
            for (int j = 0; j < hight; j++)
            {
                 arr[i,j] = Random.Shared.Next(leftRange, rightRange);
            }
           
        }

        return arr;
    }
    //input of integer array with fix dimension
    public static int[] GetArrayWithFixSize(int size, string prompt = "")
    {
        int[] inputArray = new int[size];
        Console.WriteLine($"{prompt}:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"  Input number #{i + 1}: ");
            inputArray[i] = int.Parse(Console.ReadLine());
        }
        return inputArray;
    }
    public static (int, int) SumPositiveAndNegotiveElements(int[] arr)
    {
        int sumPositive = 0; //sum of positive elements of array
        int sumNegative = 0; //sum of negative elements of array

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
    public static void PrintArray(int[] array)
    {
        Console.WriteLine($"[{String.Join(", ", array)}]");
    }
    /// <summary>
    /// Print array with different types of data
    /// </summary>
    /// <param name="arr">Incoming array of objects (two dimensions) </param>
    /// <typeparam name="T">Type of data</typeparam>
    public static void PrintArray<T>(T[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Type elementType = arr[i, j].GetType();

                if (elementType == typeof(int))
                {
                    Console.Write("{0,4}", arr[i, j]);
                }
                else if (elementType == typeof(string))
                {
                    Console.Write("{0,-20}", arr[i, j]);
                }
                else if (elementType == typeof(double))
                {
                    Console.Write("{0,8:F2}", arr[i, j]);
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine();
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
    public static int GetCountOfDigits(int tstNumber, int leftRange = 0)
    {
        int CountOfDigits = -1;
        int i = 1;
        for (; tstNumber > leftRange; i++)
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
        return sum;
    }
    public static int GetInputIntNumber(int numberOfDigit
                        , bool doCheck = false
                        , string message = "Input integer:")
    {
        int result = 0;
        string resultS;
        if (numberOfDigit == 0)
        {
            Console.Write($"{message}");
        }
        else
        {
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
