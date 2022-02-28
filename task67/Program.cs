void printN1(int n)
{
    if(n>=1)
    {
        System.Console.Write($"{n} ");
        printN1(n-1);
    }
}
printN1(20);