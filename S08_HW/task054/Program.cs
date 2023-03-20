using Libraries;
namespace task054;
class Program
{
    static void Main(string[] args)
    {
        int arraySize = 4;
        int leftRange = 0;
        int rightRange = 99;
        int[,] randomArray = Library.GetRandomArray(arraySize, arraySize, leftRange, rightRange);
        Console.Clear();
        Library.PrintArray(randomArray);
        
        //sorting by rows
        for (int i = 0; i < randomArray.GetLength(0); i++)
        {
            int tmpArrayMember = 0;
            for (int j = 0; j < randomArray.GetLength(1); j++)
            {
                int minPosition = j;
                //get minimal member of row
                for (int x = j; x < randomArray.GetLength(1); x++)
                {
                    if (randomArray[i, x] < randomArray[i, minPosition]) minPosition = x;
                }

                if (randomArray[i, j] > randomArray[i, minPosition])
                {
                    tmpArrayMember = randomArray[i, j];
                    randomArray[i, j] = randomArray[i, minPosition];
                    randomArray[i, minPosition] = tmpArrayMember;
                }
            }
        }
        Library.PrintArray(randomArray);

    }
}
