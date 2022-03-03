int numbers(double[] a)
{
    int k=0;
    for(int i=0; i<a.Length; i++)
    {
        if(a[i]>0) k++;
    }
    return k;
}
System.Console.WriteLine("Введите числа:");
double[] a=Console.ReadLine().Split(' ').Select(e => Convert.ToDouble(e)).ToArray();
System.Console.WriteLine($"Вы ввели {numbers(a)} чисел больше нуля");