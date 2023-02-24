// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

int GetInput(){
    string? tmp = null;
    while (tmp == null){
        tmp = Console.ReadLine();
        if (tmp == null){
            Console.WriteLine("Nullable vaules are forboted");
        }
    }
    int res = Convert.ToInt32(tmp);
    return res;
}
void Print(string arg, Boolean wrapDont){
    if (wrapDont) {
        Console.Write(arg);
    }else {
        Console.WriteLine(arg);
    }
}

Console.Clear();
Print("a=",true);
int a = GetInput();
Print("b=",true);
int b = GetInput();
int max = a;
if (b > a) {
    max = b;
}
Print($" a = {a}; b = {b}; max = {Convert.ToString(max)}",false);