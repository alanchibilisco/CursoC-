using System.Text.RegularExpressions;

namespace ConsoleApp1;

public class Program
{
    public static void Main(string[]args)
    {
        System.Console.WriteLine("hi world");

        string text="Mi nombre es Alan, mi telefono es 3815842864 y mi codigo postal es 4015";

        string web="http://localhost:8001";
        //busca solo la letra A
        string pattern="[A]";
        //busca que aparezcan numeros el @ antes de la declaracion es para que reconozca la \
        string pattern2=@"\d{10}";

        string pattern3="https|http?://";

        Regex regex=new Regex(pattern);

        Regex regexTel=new Regex(pattern2);

        Regex regexWeb=new Regex(pattern3);

        var result=regex.Match(text);

        System.Console.WriteLine(result);

        MatchCollection collection=regex.Matches(text);

        System.Console.WriteLine(collection.Count);

        bool result2=regexTel.IsMatch(text);

        if(result2)System.Console.WriteLine("si posee un numero de telefono");
        else System.Console.WriteLine("no posee un numero de telefono");

        bool match=regexWeb.IsMatch(web);

        System.Console.WriteLine("match web --> {0}",match);


    }
}