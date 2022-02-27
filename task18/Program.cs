bool[] X={true, false};
bool[] Y={true, false};
bool flag=true;
for(int i=0; i<2; i++)
{
    for(int j=i;j<2;j++)
    {
        if(!(X[i] || Y[j])!=(!X[i] && !Y[j]))
        {
            flag=false;
            break;
        }
    }
}
if(flag) System.Console.WriteLine("the expression is true");
else System.Console.WriteLine("the expression is false");