bool weekend(int a)
{
    if(a==6 || a==7) return true;
    else return false;
}
int n;
string s;
System.Console.WriteLine("Write a day of week");
s = Console.ReadLine();
n = Convert.ToInt32(s);
if(weekend(n)) System.Console.WriteLine("день недели является выходным"); 
else System.Console.WriteLine("день недели не является выходным");