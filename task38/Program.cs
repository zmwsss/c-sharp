int SumOdd(int[] a)
{
    int sum=0;
    for(int i=0; i<a.Length; i++)
    {
        if(i%2==0) sum+=a[i];
    }
    return sum;
}

int[] a=new int[10];
Random rand = new Random();
for(int i=0; i<a.Length; i++)
{
    a[i]= rand.Next(-10, 10);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
System.Console.WriteLine(SumOdd(a));
