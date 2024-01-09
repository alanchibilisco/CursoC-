// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

namespace StreamReader
{
    class Stream
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file = null;

            try
            {
                string line;
                int contador = 0;
                string path = @"/home/alan/CursoC#/repos.txt";
                file = new System.IO.StreamReader(path);

                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    contador++;
                }

            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Error --> {e}");

            }
            finally
            {
                if (file != null)
                {
                    file.Close();

                }
            }

            System.Console.WriteLine(file);
        }
    }
}
