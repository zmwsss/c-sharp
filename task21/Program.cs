bool palindrome(int a)
{
    int b,c,i=0;
    for(b=a%10,c=a/10000; i<2;a/=10,b=a%10,c%=10)
    {
        if(b!=c)
        return false;
        i++;
        c=a/(int)Math.Pow(10,2-i);
    }
    return true;
}
int a;
string s;
System.Console.WriteLine("Enter a five-digit number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
if(palindrome(a)) System.Console.WriteLine($"{a} is a palindrome");
else System.Console.WriteLine($"{a} is not a palindrome");