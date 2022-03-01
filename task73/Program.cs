int Sum2(int a0, int a1, int n)
{
    if(n==3) return a0+a1;
    else if(n==2) return a1;
    else if(n==1) return a0;
    return Sum2(a0, a1, n-1)+Sum2(a0, a1, n-2);
}
int n=7;
int a0=2;
int a1=2;
for(int i=1; i<n;i++)
System.Console.Write($"{Sum2(a0,a1,i)} ");