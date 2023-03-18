//Задание 1

string string1 = "Арина Даша Маша";
string new_string = string1.Substring();
Console.WriteLine(new_string);
for(int i =0; i < nnn.Length & nnn[i]!="Маша"; i++)
{
    Console.WriteLine(nnn[i]);
}
string str = names.Substring(0, names.IndexOf("Маша")).Replace(" ", "\n");
Console.WriteLine(str);

//Задание 2

//string love = "love_is";
//string str = Console.ReadLine();
//string[] words = str.Split(" ");
//for (int i = 0; i < words.Length; i++)
//{
//    if (words[i].Length==4)
//    {
//        words[i] = love;
//    }
//}
//str = string.Join(" ", words);
//Console.WriteLine(str);

//Задание 3 (разобраться как вставлять смайлик)

//string str = Console.ReadLine();
//int n = Convert.ToInt32(Console.ReadLine());
//string new_str = "";

//for (int i = 0; i < str.Length; i++)
//{
//    if (i % n == 0)
//    {
//        new_str += Convert.ToChar('\u263A');
//    }
//    new_str += str[i];
//}
//Console.WriteLine(new_str);

//Задание 4

//string str = Console.ReadLine();
//string[] word = str.Split(" ");
//int maxLen = 0;
//int minLen = 10000;
//string maxWord = word[0];
//string minWord = word[0];
//for (int i = 0; i < word.Length; i++)
//{
//    if (word[i].Length> maxLen)
//    {
//        maxLen = word[i].Length;
//        maxWord = word[i];
//    }
//    if (word[i].Length <minLen)
//    { 
//        minLen = word[i].Length;
//        minWord = word[i];  
//    }
//}
//string newStr = "";
//for (int x = 0; x < maxWord.Length; x++)
//{
//    newStr += maxWord + ",";
//}
//for (int y = 0; y < minWord.Length; y++)
//{
//    newStr += minWord + ",";
//}
//Console.WriteLine(newStr);

//Задание 5

//string str = Console.ReadLine();
//string[] word = str.Split(" ");
//string new_str = "";
//for (int i = 0; i < word.Length; i++)
//{
//    bool inNew = false;
//    for (int j = 0; j < i; j++)
//    {
//        if (word[i] == word[j])
//        {
//            inNew = true;
//            break;
//        }
//    }
//    if (inNew==false)
//    {
//        new_str+= word[i]+" "; 
//    }
//}
//Console.WriteLine(new_str);

//Задание 6

using System.Diagnostics.Tracing;
using System.Text;
string strings;
StringBuilder sb = new StringBuilder();
do
{
    strings = Console.ReadLine();
    string[] word = strings.Split(" ");
    for (int i = 0; i < word.Length;i++)
    {
        if (i % 3 == 0)
        {
            sb.Append(word[i] + " ");
        }
        else if (i % 3 == 1)
        {
            sb.Append(string.Join("", word[i].ToCharArray().Reverse()) + " ");
        }
        else if (i%3==2)
        {
            sb.Append("");
        }
        if (i == word.Length-1)
        {
            sb.Append(".");
        }
    }
}
while (strings != " ");
Console.WriteLine(sb.ToString());

//Задание 7

using System.Text;

StringBuilder sb = new StringBuilder();
string str = "Киев Нью-Йорк Амстердам Вена Мельбурн";
string[] word = str.Split(' ');
sb.Append(word[0]);
for (int i = 0; i < word.Length; i++)
{
    for (int j= 1; j < word.Length; j++)
    {
        if (i==j)
        {
            continue;
        }
        if (sb[sb.Length - 1].ToString().ToLower() == word[j][0].ToString().ToLower())
        {
            sb.Append(" ");
            sb.Append(word[j]);
            break;
        }
    }
}
Console.WriteLine(sb.ToString());