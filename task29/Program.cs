int fact(int n)
{
    int i, factorial=1;
    for(i=1;i<=n;i++)
    {
        factorial*=i;
    }
    return factorial;
}
int n;
string s;
System.Console.WriteLine("Enter a number");
s=Console.ReadLine();
n=Convert.ToInt32(s);
System.Console.WriteLine($"factorial {n} is {fact(n)}");
