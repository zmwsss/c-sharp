// Найти сумму чисел от 1 до N
int n, sum=0;
string s;
System.Console.WriteLine("Enter a number");
s=Console.ReadLine();
n=Convert.ToInt32(s);
for(int i=1;i<=n;i++)
{
    sum+=i;
}
System.Console.WriteLine(sum);