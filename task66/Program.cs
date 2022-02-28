void print1N(int i, int n)
{
    if(i<=n) 
    {   
        System.Console.Write($"{i} ");
        print1N(i+1,n);
    }
}
print1N(1,20);