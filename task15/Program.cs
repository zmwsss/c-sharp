int digit3(int n)
{
    n/=100;
    n%=10;
    return n;
}

int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
if(n<100) System.Console.WriteLine("У числа нет третьей цифры");
System.Console.WriteLine(digit3(n));
