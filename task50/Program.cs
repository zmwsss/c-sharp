void Input(int m, int n, int[,] a)
{
    Random rand=new Random();
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            a[i,j]=rand.Next(10,99);
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void change(int[,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            if(a[i,j]%2==0) a[i,j]=-a[i,j];
        }
    }
}

void print(int[,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j]}  ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите число строк:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[m,n];
Input(m,n,a);
change(a);
print(a);

