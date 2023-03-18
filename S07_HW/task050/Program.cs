using Libraries;
namespace task050;
class Program
{
    static void Main(string[] args)
    {
        int mSize = 4;
        int nSize = 4;
        int leftRange = -99;
        int rightRange = 99;
        //create a two dimension array
        int horizontalPosition = Library.GetNumber("Input horizontal position m");
        int verticalPosition = Library.GetNumber("Input vertical position n");
        int[,] newArray = Library.GetRandomArray(mSize, nSize, leftRange, rightRange);

        Library.PrintArray(newArray);
        if (horizontalPosition >= newArray.GetLength(0) ||
            horizontalPosition < 0 ||
            verticalPosition >= newArray.GetLength(1) ||
            verticalPosition < 0)
        {
            System.Console.WriteLine($"Element with position [{horizontalPosition},{verticalPosition}] -> there is no element (OutOfBounds)");
        }
        else
        {
            System.Console.WriteLine($"Element with [{horizontalPosition},{verticalPosition}] -> {newArray[horizontalPosition, verticalPosition]}");
        }

    }
}
