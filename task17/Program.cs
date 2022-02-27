int kvadr(int a, int b)
{
    if(a==b*b)
    return 1;
    if(b==a*a)
    return 2;
    return 0;
}

int a, b;
string s;
System.Console.WriteLine("Write a number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(kvadr(a,b)==0) System.Console.WriteLine($"neither {a} nor {b} are squares of each other");
if(kvadr(a,b)==1)  System.Console.WriteLine($"{a} is the square of {b}");
if(kvadr(a,b)==2) System.Console.WriteLine($"{b} is the square of {a}");

