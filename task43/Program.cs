int bit(int a)
{
    int n=0;
    for(int i=30;i>=0;i--)
    {

        if(a==(int)Math.Pow(2,i))
        {
             n+=(int)Math.Pow(10,i);
             return n;
        }
        if(a>(int)Math.Pow(2,i))
            {
             n+=(int)Math.Pow(10,i);
             a-=(int)Math.Pow(2,i);
            }

    }
    return n;
}
int a;
string s;
System.Console.WriteLine("Enter a positive number");
s=Console.ReadLine();
a=Convert.ToInt32(s);
System.Console.WriteLine(bit(a));

