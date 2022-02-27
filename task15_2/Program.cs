int div(int a)
{
    int r1=a%7;
    int r2=a%23;
    return r1+r2;
}

int a;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
a = Convert.ToInt32(s);
if(div(a)==0) System.Console.WriteLine($"{a} делится на 7 и 23");
else System.Console.WriteLine($"{a} не делится на 7 и 23");