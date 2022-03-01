bool combination(string a, string b)
{
    bool flag;
    for(int i=0;i<a.Length && a.Length>=b.Length;i++)
    {
        flag=false;
        for(int j=0;j<b.Length;j++)
        {
            if(a[i]==b[j]) flag=true;
        }
        if(!flag) return false;
    }
    
    return true;
}
System.Console.WriteLine("Введите первое слово");
string s1=Console.ReadLine();
System.Console.WriteLine("Введите второе слово, не длиннее второго");
string s2=Console.ReadLine();
if(combination(s1,s2)) System.Console.WriteLine("Из букв первого слова можно составить второе слово");
else System.Console.WriteLine("Из букв первого нельзя слова можно составить второе слово");