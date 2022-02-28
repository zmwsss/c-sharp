int printSumM_N(int m, int n)
{
    if(m==n) return n;
    return m+printSumM_N(m+1,n);
}
System.Console.WriteLine(printSumM_N(1,2));