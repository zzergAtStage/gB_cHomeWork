namespace taskWithAsterisk;
class Program
{
    //вернем в массиве, где 0-ой элемент - первый Max, второй[1] - второй completed
    static void Main(string[] args)
    {
        int[] numbers = {4, 4, 3, 0, 2};
        int[] result = GetSecondMaxValueFromArray(numbers);
        if (result[1] == int.MinValue)
        {
            System.Console.WriteLine($"There is no second max value");
        }
        else
        {
            System.Console.WriteLine($"The second maximum number is {result[1]}.");
        }
    }
    /// <summary>
    /// Returns a second maximum value from array with integer values
    /// </summary>
    /// <param name="pArray">In array</param>
    /// <returns>New array with two values: firstmax, secondmax</returns>
    static int[] GetSecondMaxValueFromArray(int[] pArray)
    {
        int max = int.MinValue;
        int secondMax = int.MinValue;
        int[] result = new int[2];
        foreach (int num in pArray)
        {
            if (num > max)
            {
                secondMax = max;
                max = num;
            }
            else if (num > secondMax && num != max)
            {
                secondMax = num;
            }
        }
        result[0] = max;

        if (secondMax == int.MinValue)
        {
            return result;
        }
        else
        {
            result[1] = secondMax;
            return result;
        }
    }

}
