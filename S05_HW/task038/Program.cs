using Libraries;
namespace task038;
class Program
{
    static void Main(string[] args)
    {
        int[] array = Library.GetRandomArray(7,-100,100);
        Library.PrintArray(array);
        System.Console.WriteLine($"Substraction is: {GetSubstrMinMax(array)}");

    }

    static int GetSubstrMinMax(int[] pArr){
        int res = 0;
        int minMember = 0, maxMember = 0;
        for (int i = 0; i < pArr.Length; i++)
        {
            if (pArr[i] < pArr[minMember]){
                minMember = i;
            }  
            if (pArr[i] > pArr[maxMember]){
                maxMember = i;
            }
        }
        System.Console.WriteLine($"minMember={minMember+1}; maxMember={maxMember+1}");
        return pArr[maxMember] - pArr[minMember];
    }
}
