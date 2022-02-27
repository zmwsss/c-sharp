int div(int a, int b)
{
    return a%b;
}

int a, b;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
a = Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
b = Convert.ToInt32(s);
if(div(a,b)==0) System.Console.WriteLine($"{a} делится на {b}");
else System.Console.WriteLine($"{a} делится на {b} с остатком {div(a,b)}");