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
                int maxValPosition = j;
                //get minimal member of row
                for (int x = j; x < randomArray.GetLength(1); x++)
                {
                    if (randomArray[i, x] > randomArray[i, maxValPosition]) maxValPosition = x;
                }
                //System.Console.WriteLine($" maxValPosition = {maxValPosition}; row = [{i}], j ={j}");
                //swap minMembers via rows
                if (randomArray[i, j] < randomArray[i, maxValPosition])
                {
                    tmpArrayMember = randomArray[i, j];
                    randomArray[i, j] = randomArray[i, maxValPosition];
                    randomArray[i, maxValPosition] = tmpArrayMember;
                }
            }
        }
        System.Console.WriteLine("Ordered array:");
        Library.PrintArray(randomArray);

    }
}
