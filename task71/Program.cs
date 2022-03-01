double MyPow(double a, int b)
{
    if(b>0) return a*MyPow(a,b-1);
    else if(b<0) return 1/a*MyPow(a,b+1);
    else return 1;
}
System.Console.WriteLine(MyPow(2,5));