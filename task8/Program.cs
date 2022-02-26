int n;
string s;
System.Console.WriteLine("Write a number");
s = Console.ReadLine();
n = Convert.ToInt32(s);
for(int i=-n;i<=n;i++) System.Console.Write($"{i} ");
