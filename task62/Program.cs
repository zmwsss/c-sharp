int[,] DeleteIJ(int[,] a, int m, int n)
{
    int[,] New_a=new int[a.GetLength(0)-1,a.GetLength(1)-1];
    int k=0, l=0;
    for(int i=0; i<a.GetLength(0); i++)
    {
        if(i==m) continue;
        for(int j=0; j<a.GetLength(1); j++)
        {
            if(j==n) continue;
            New_a[k,l]=a[i,j];
            l++;
        }
        k++;
        l=0;
    }
    return New_a;
}

void FindMin(int[,] a, out int m, out int n)
{
    int min = a[0,0];
    m=0;
    n=0;
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            if(a[i,j]<min) 
            {
                min=a[i,j];
                m=i;
                n=j;
            }
        }
    }
}
void Input(int[,] a)
{
    Random rand=new Random();
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            a[i,j]=rand.Next(0,99);
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

void print(int[,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите число строк:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[m,n];
Input(a);
FindMin(a, out m, out n);
System.Console.WriteLine();
print(DeleteIJ(a, m, n));