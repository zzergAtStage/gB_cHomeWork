namespace task060;
class Program
{
    static void Main(string[] args)
    {   //Так как в условии не сказано про случайные неповторяющиеся числа,
    // введена простая линейная последовательность!
        Console.Clear();
        int[,,] threeDimArray = new int[2, 2, 2];
        FillTreeDimentionsArray(ref threeDimArray);
        PrintTreeDimentionsArray(ref threeDimArray);

        static void FillTreeDimentionsArray(ref int[,,] pThreeDimArray)
        {
            int arrSize = pThreeDimArray.GetLength(0);
            int startValue = 10;
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    for (int y = 0; y < arrSize; y++)
                    {
                        pThreeDimArray[i, j, y] = startValue++;//сквозной инкремент
                    }
                }

            }

        }
        static void PrintTreeDimentionsArray(ref int[,,] pThreeDimArray)
        {
            int arrSize = pThreeDimArray.GetLength(0);
            for (int i = 0; i < arrSize; i++)
            {
                for (int j = 0; j < arrSize; j++)
                {
                    for (int y = 0; y < arrSize; y++)
                    {
                        Console.Write($"{pThreeDimArray[i, j, y]}({i},{j},{y}) ");
                    }
                    System.Console.WriteLine();
                }
            }
        }
    }
}
