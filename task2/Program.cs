int kvadr(int a)
{
    a*=a;
    return a;
}

int a;
string s;
System.Console.WriteLine("Write a number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine(kvadr(a));
