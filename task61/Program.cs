void matrix(int[,] A, int[,] B, int[,] C)
{
    for(int i=0; i<A.GetLength(0); i++)
    {
        for(int j=0; j<A.GetLength(1); j++)
        {
            for(int k=0; k<A.GetLength(1); k++)
            C[i,j]+=A[i,k]*B[k,j];
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

System.Console.WriteLine("Введите число строк первой матрицы:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов первой матрицы:");
int k=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число строк второй матрицы:");
int l=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов второй матрицы:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] A=new int[m,k];
int[,] B=new int[l,n];
int[,] C=new int[m,n];
Input(A);
System.Console.WriteLine();
Input(B);
if(A.GetLength(1)!=B.GetLength(0)) System.Console.WriteLine("число столбцов первой матрицы не равно числу строк второй матрицы");
else
{
    matrix(A,B,C);
    System.Console.WriteLine();
    print(C);
}