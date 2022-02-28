int show(int[] a)
{
    int k=0;
    for(int i=0; i<a.Length; i++)
    {
        if(a[i]%2==0) k++;
    }
    return k;
}

int[] a=new int [10];
Random rand= new Random();
for(int i=0;i<a.Length;i++)
{
    a[i]=rand.Next(99,999);
    System.Console.Write($"{a[i]} ");
}
System.Console.WriteLine();
System.Console.WriteLine($"{show(a)} четных чисел");
System.Console.WriteLine($"нечетных чисел {a.Length-show(a)}");