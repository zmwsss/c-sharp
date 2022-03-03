/*void Input(int m, int n, int[,] a)
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
*/
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
void CreateSumIndex(int[,] a)
{
    for(int i=0; i<a.GetLength(0); i++)
    {
        for(int j=0; j<a.GetLength(1); j++)
        {
            a[i,j]=i+j;
        }
    }
}
System.Console.WriteLine("Введите число строк:");
int m=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число столбцов:");
int n=Convert.ToInt32(Console.ReadLine());
int[,] a=new int[m,n];
CreateSumIndex(a);
print(a);
