int deldigit(int n)
{
    int a=n/100;
    int b=n%10;
    n=a*10+b;
    return n;
}

int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
System.Console.WriteLine(deldigit(n));