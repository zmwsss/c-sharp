void homothety(double k, Point[] a)
{
    for(int i=0; i<a.Length; i++)
    {
        a[i].x*=k;
        a[i].y*=k;
    }
}
Point[] points=new Point[4];
Random rand = new Random();
points[0].name = "A";
points[1].name = "B";
points[2].name = "C";
points[3].name = "D";
for(int i=0; i<points.Length; i++)
{
    points[i].x = rand.Next(0,10);
    points[i].y = rand.Next(0,10);
    points[i].Printf();
}
homothety(0.5, points);
System.Console.WriteLine("После масштабирования вершины имеют координаты:");
for(int i=0; i<points.Length; i++)
{
    points[i].Printf();
}
struct Point
{
    public string name;
    public double x,y;  
    public void Printf()
    {
        System.Console.WriteLine($"Вершина {name} имеет координаты x={x}, y={y}");
    }
}