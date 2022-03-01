//int n=Convert.ToInt32(Console.ReadLine());
void Words(string alphabet, char[]word, int length)
{
    if(length==word.Length) 
    {
        System.Console.Write($"{new String(word)} ");
        return;
    }
    for(int i=0;i<alphabet.Length;i++)
    {
        word[length]=alphabet[i];
        Words(alphabet, word,length+1);
    }
}
Words("аисв", new char[3], 0);