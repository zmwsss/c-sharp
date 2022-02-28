bool triangle(double a, double b, double c)
{
    if(a+b>c && a+c>b && b+c>a) return true;
    return false;
}
double a, b ,c;
string s;
System.Console.WriteLine("Enter a hand of triangle");
s=Console.ReadLine();
a=Convert.ToDouble(s);
System.Console.WriteLine("Enter a hand of triangle");
s=Console.ReadLine();
b=Convert.ToDouble(s);
System.Console.WriteLine("Enter a hand of triangle");
s=Console.ReadLine();
c=Convert.ToDouble(s);
if(triangle(a,b,c)) System.Console.WriteLine($"{a} {b} {c} are hands of triangle");
else System.Console.WriteLine($"{a} {b} {c} are not hands of triangle");
