// Определить количество цифр в числе
int a, i;
string s;
System.Console.WriteLine("Enter a number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
for(i=0;a>0;i++)
{
    a/=10;
}
System.Console.WriteLine($"number of digits are {i}");