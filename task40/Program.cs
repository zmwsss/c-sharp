// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
double differrence(double[] a)
{
    double max=a[0], min=a[0];
    for(int i=1; i<a.Length; i++)
    {
        if(max<a[i]) max=a[i];
        if(min>a[i]) min=a[i];
    }
    return max-min;
}
double[] a=new double[20];
Random rand = new Random();
for(int i=0; i<a.Length; i++)
{
    a[i]= rand.Next(-100,100) + rand.NextDouble();
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
System.Console.WriteLine(differrence(a));