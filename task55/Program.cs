void average(int[,] a, double[] SumAverage)
{
    for(int j=0; j<a.GetLength(1); j++)
    {
        for(int i=0; i<a.GetLength(0); i++)
        {
            SumAverage[j]+=a[i,j];
        }
        SumAverage[j]/=a.GetLength(0);
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
void print(double[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        System.Console.Write($"{a[i]}  ");
    }
}
System.Console.WriteLine("Введите число строк:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[m,n];
double[] AverageSum=new double[a.GetLength(1)];
Input(a);
average (a, AverageSum);
print(AverageSum);