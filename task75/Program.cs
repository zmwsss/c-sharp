bool LettersCombination(string A, string B)
{
    for(int n=0; n<B.Length; n++)
    {
        bool flag=false;
        for(int m=0; m<A.Length; m++)
        {
        if(A[m]==B[n]) flag=true;
        }
        if(!flag) return false;
    }
    return true;
}
System.Console.WriteLine("Введите первое слово:");
string a=Console.ReadLine();
System.Console.WriteLine("Введите второе слово:");
string b=Console.ReadLine();
if(LettersCombination(a,b)) System.Console.WriteLine("Из букв первого слова можно составить второе слово");
else System.Console.WriteLine("Из букв первого слова невозможно составить второе слово");
if(LettersCombination(b,a)) System.Console.WriteLine("Из букв второго слова можно составить первое слово");
else System.Console.WriteLine("Из букв второго слова невозможно составить первое слово");
