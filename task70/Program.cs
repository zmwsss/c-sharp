int SumDigigts(int n)
{
    if(n<10) return n;
    return n%10+SumDigigts(n/10);
}
System.Console.WriteLine(SumDigigts(12345));