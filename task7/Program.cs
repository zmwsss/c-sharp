int unoreven(int a)
{
    return a%2;
}
int a;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
a = Convert.ToInt32(s);
if(unoreven(a)==0) System.Console.WriteLine($"{a} четное");
else System.Console.WriteLine($"{a} нечетное");
