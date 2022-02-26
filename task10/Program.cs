int digit(int n)
{
    n%=10;
    return n;
}

int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
System.Console.WriteLine(digit(n));
