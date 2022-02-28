// int SumOdd(int[] a)
// {
//     int sum=0;
//     for(int i=0; i<a.Length; i++)
//     {
//         if(i%2==0) sum+=a[i];
//     }
//     return sum;
// }

// int[] a=new int[10];
// Random rand = new Random();
// for(int i=0; i<a.Length; i++)
// {
//     a[i]= rand.Next(-10, 10);
//     System.Console.Write($"{a[i]} ");
// }
// System.Console.WriteLine();
// System.Console.WriteLine(SumOdd(a));
void bitprint(int a)
{
    for(int i=31;i>=0;i--)
    {
        if((a&(1<<i))!=0) System.Console.Write(1);
        else System.Console.Write(0);
        if(i%8==0) System.Console.Write($" ");
    }
}
int a=int.Parse(Console.ReadLine());
System.Console.WriteLine(a);
bitprint(a);