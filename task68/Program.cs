void printM_N(int m, int n)
{
    if(m<=n)
    {
        System.Console.Write($"{m} ");
        printM_N(m+1,n);
    }
}
printM_N(13,27);
