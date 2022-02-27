// Возведите число А в натуральную степень B используя цикл
int a, b;
string s;
System.Console.WriteLine("Enter a number A");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Enter a number B");
s=Console.ReadLine();
b=Convert.ToInt32(s);
int t=a;
for(int i=1;i<b;i++)
{
    a*=t;
    
}
System.Console.WriteLine($"A to the power of B is {a}");

