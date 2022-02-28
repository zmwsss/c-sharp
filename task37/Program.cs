 int kolvo(int[] a)
 {
     int n=0;
     for(int i=0; i<a.Length;i++)
     {
         if(a[i]>=10 && a[i]<=99) n++;
     }
     return n;
 }
 int[] a=new int [123];
 Random rand= new Random();
 for(int i=0;i<a.Length;i++)
{
    a[i]=rand.Next(10,99);
}
 System.Console.WriteLine(kolvo(a));