bool num(int[] a, int b)
{
    for(int i=0; i<a.Length; i++)
    if(a[i]==b) return true;
    return false;
}
int[] a=new int[12];
int b;
string s;
System.Console.WriteLine("enter a number");
s=Console.ReadLine();
b=Convert.ToInt32(s);
Random rand = new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=rand.Next(-9,9);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
if(num(a,b)) System.Console.WriteLine($"{b} is an array");
else System.Console.WriteLine($"{b} is not an array");