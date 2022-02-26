bool maxmin(int a, int b)
{
    if (a > b) return true;
    else return false;
}

int a, b;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
b = Convert.ToInt32(s);
if (maxmin(a, b)) System.Console.Write($"{a}>{b}");
else System.Console.Write($"{a} < {b}");
