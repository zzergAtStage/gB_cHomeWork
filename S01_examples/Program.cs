class Program
{
    public static void Main(string[] args){
        int GetInput(){
            string tmp = Console.ReadLine();
            if (tmp == null){
                Console.WriteLine("Nullable vaules are forboted");
            }
            int res = Convert.ToInt32(tmp);
            return res;
        }
        
        Console.Write(" Input new value:");
        int num = GetInput();
        num = num * num;
        Console.Clear();
        Console.WriteLine("Res: " + num);

    }
}