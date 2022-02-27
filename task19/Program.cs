int quarter(double x, double y)
{
    if(x>0 && y>0) return 1;
    if(x>0 && y<0) return 4;
    if(x<0 && y>0) return 2;
    return 3;
}

double x, y;
string s;
System.Console.WriteLine("enter the x coordinate");
s = Console.ReadLine();
x = Convert.ToDouble(s);
System.Console.WriteLine("enter the y coordinate");
s = Console.ReadLine();
y = Convert.ToDouble(s);
System.Console.WriteLine($"the point with the {x} and {y} coordinates is in the {quarter(x,y)} quarter");