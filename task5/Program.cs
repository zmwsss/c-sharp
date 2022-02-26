int max(int a, int b, int c)
{
    int Max = a > b ? a : b;
    Max = Max > c ? Max : c;
    return Max;
}

int a, b, c;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
b = Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
c = Convert.ToInt32(s);
System.Console.WriteLine(max(a,b,c));
