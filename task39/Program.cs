int[] a=new int[21];
string s;
Random rand = new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=rand.Next(1,21);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
for(int i=0;i<a.Length/2;i++)
{
    System.Console.WriteLine($"a[{i}] x a[{a.Length-1-i}] = {a[i]*a[a.Length-1-i]} ");
}