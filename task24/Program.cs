// Показать кубы чисел от 1 до N
int n;
string s;
System.Console.WriteLine("Enter a number");
s=Console.ReadLine();
n=Convert.ToInt32(s);
for(int i=1;i<=n;i++)
{
    System.Console.WriteLine($"the cube of the number {i} is {i*i*i}");
}
