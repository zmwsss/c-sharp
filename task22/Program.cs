double dist(double x0, double y0, double z0, double x1, double y1, double z1)
{
    return Math.Sqrt((x0-x1)*(x0-x1)+(y0-y1)*(y0-y1)+(z0-z1)*(z0-z1));
}
double x0, y0, z0, x1, y1, z1;
string s;
System.Console.WriteLine("ordinate of point A=");
s=Console.ReadLine();
x0=Convert.ToDouble(s);
System.Console.WriteLine("abscissa of point A=");
s=Console.ReadLine();
y0=Convert.ToDouble(s);
System.Console.WriteLine("application of point A=");
s=Console.ReadLine();
z0=Convert.ToDouble(s);

System.Console.WriteLine("ordinate of point B=");
s=Console.ReadLine();
x1=Convert.ToDouble(s);
System.Console.WriteLine("abscissa of point B=");
s=Console.ReadLine();
y1=Convert.ToDouble(s);
System.Console.WriteLine("application of point B=");
s=Console.ReadLine();
z1=Convert.ToDouble(s);

System.Console.WriteLine("distance between A and B equals "+dist(x0,y0,z0,x1,y1,z1));


