int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
for(int i=1;i<=n;i++){
    if(i%2==0) System.Console.Write($"{i} ");
    }
