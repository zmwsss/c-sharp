int SumPos(int[] a)
{
    int sumpos=0;
    for(int i=0;i<a.Length;i++)
    {
        if(a[i]>0) sumpos+=a[i];
    }
    return sumpos;
}
int SumNeg(int[] a)
{
    int sumneg=0;
    for(int i=0;i<a.Length;i++)
    {
        if(a[i]<0) sumneg+=a[i];
    }
    return sumneg;
}
int[] a=new int[12];
Random rand = new Random();
for(int i=0;i<12;i++)
{
    a[i]=rand.Next(-9,9);
    System.Console.WriteLine($"a[{i}]={a[i]}");
}
System.Console.WriteLine($"Sum of positive numbers is {SumPos(a)}");
System.Console.WriteLine($"Sum of negative numbers is {SumNeg(a)}");
