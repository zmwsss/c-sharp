void fibonacci(int[] a)
{
    a[0]=1;
    a[1]=1;
    for(int i=2;i<a.Length;i++)
    {
        a[i]=a[i-1] + a[i-2];
    }
}

int n;
string s;
System.Console.WriteLine("Enter № of fibonacci");
s=Console.ReadLine();
n=Convert.ToInt32(s);
int[] a=new int[n];
fibonacci(a);
for(int i=0; i<n; i++)
{
    System.Console.Write($"{a[i]} ");
}