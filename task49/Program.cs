void Input(int m, int n, double[,] a)
{
    Random rand=new Random();
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            a[i,j]=rand.Next(10,99)+rand.NextDouble();
            System.Console.Write($"{a[i,j]} ");
        }
        System.Console.WriteLine();
    }
}
System.Console.WriteLine("Введите число строк:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов:");
int n=Convert.ToInt32(Console.ReadLine());
double[,] a=new double[m,n];
Input(m,n,a);
