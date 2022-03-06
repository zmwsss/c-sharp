void Spiral(int[,] a)
{
    int M=a.GetLength(0);
    int i=0;
    int j=0;
    for(int k=1; k<=M*M; k++)
    {
        a[i,j]=k;
        if(i<=j+1 && i+j<M-1) j++;
        else if (i<j && i+j>=M-1) i++;
        else if (i>=j && i+j>M-1) j--;
        else  i--;
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

System.Console.WriteLine("Введите число строк, равное числу столбцов:");
int m=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[m,m];
Spiral(a);
print(a);