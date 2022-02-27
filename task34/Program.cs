void replace(int[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        a[i]=-a[i];
    }
}
int[] a=new int[12];
Random rand = new Random();
for(int i=0;i<12;i++)
{
    a[i]=rand.Next(-9,9);
    System.Console.Write($"{a[i]} ");
}
replace(a);
System.Console.WriteLine();
for(int i=0;i<12;i++)
{
    System.Console.Write($"{a[i]} ");
}

