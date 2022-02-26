int maxdigit(int n)
{
    int a=n/10;
    int b=n%10;
    int max=a>b ? a:b;
    return max;
}

int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
System.Console.WriteLine(maxdigit(n));
