using Libraries;
namespace task0062;
class Program
{
    static int count = 0;
    static int arraySize = 7;
    const int RIGHT = 0;
    const int DOWN = 1;
    const int LEFT = 2;
    const int UP = 3;
    static int leftFilled;
    static int bottomFilled;
    static int topFilled;
    static int rightFilled;
    static void Main(string[] args)
    {
        //решил попробовать через рекурсию... не хватило понимания или терпения.
   
        Console.Clear();
        int[,] spinArray = new int[arraySize, arraySize];
        rightFilled = spinArray.GetLength(1) - 1;
        leftFilled = 0;
        bottomFilled = spinArray.GetLength(0) - 1;
        topFilled = 0;
        MazeFillingArray(RIGHT, 0, 0, spinArray);
        Library.PrintArray(spinArray);
    }

    static void MazeFillingArray(int direction, int row, int col, int[,] maze)
    {
        //System.Console.WriteLine($"direction:{direction}; row:{row}; col:{col}");
        while (topFilled <= bottomFilled && leftFilled <= rightFilled)
        {
            switch (direction)
            {
                case RIGHT:
                    for (int i = leftFilled; i <= rightFilled; i++)
                    {
                        maze[topFilled, i] = ++count;
                    }
                    topFilled++;
                    break;
                case DOWN:
                    for (int i = topFilled; i <= bottomFilled; i++)
                    {
                        maze[i, rightFilled] = ++count;
                    }
                    rightFilled--;
                    break;
                case LEFT:
                    for (int i = rightFilled; i >= leftFilled; i--)
                    {
                        maze[bottomFilled, i] = ++count;
                    }
                    bottomFilled--;
                    break;
                case UP:
                    for (int i = bottomFilled; i >= topFilled; i--)
                    {
                        maze[i, leftFilled] = ++count;
                    }
                    leftFilled++;
                    break;
            }
            direction = (direction + 1) % arraySize;
        }

    }
    
}
