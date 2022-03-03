void InvertSort(int[,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            for(int k=0; k<a.GetLength(1)-1; k++)
            {
                if(a[i,k]<a[i,k+1])
                {
                    int tmp=a[i,k];
                    a[i,k]=a[i,k+1];
                    a[i,k+1]=tmp;
                }
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
            a[i,j]=rand.Next(10,99);
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
InvertSort(a);
System.Console.WriteLine();
print(a);