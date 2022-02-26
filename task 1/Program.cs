bool kvadr(int a, int b)
{
    if(a==b*b) return true;
    else return false;
}
int a, b;
string s;
System.Console.WriteLine("Write a number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine("Write a number");
s=Console.ReadLine();
b=Convert.ToInt32(s);
if(kvadr(a,b)) System.Console.WriteLine($"{a} является квадратом {b}");
else System.Console.WriteLine($"{a} не является квадратом {b}");
