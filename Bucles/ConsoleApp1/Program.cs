// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography;

namespace Bucles
{
    class App
    {
        static void Main(string[] args)
        {
            //Bucles indeterminados
            int contador = 0;
            while (contador <= 5)
            {
                System.Console.WriteLine("Se ejecuto el bucle while");
                contador++;
            }

            bool repeat = false;
            do
            {
                System.Console.WriteLine($"El valor de repeat es--> {repeat}");
            } while (repeat);

            //bucles determinados

            string[] arr = { "hi", "hello", "hola", "ciao" };

            try
            {
                for (int i = 0; i <= arr.Length; i++)
                {
                    System.Console.WriteLine($"El valor de la posicion {i} es --> {arr[i]}");
                }
            }
            catch (System.Exception error) //NOTA, se pueden concatener mas de un catch, tambien se puede agregar un filtrado de excepciones con when (error.getType()!= o == [EXCEPTION])
            {
                System.Console.WriteLine($"Se produjo un error {error}");
            }


            foreach (var item in arr)
            {
                System.Console.WriteLine($"El valor de la posicion  es {item}");
            }

            //crear un int aleatorio como maximo 100

            var random = new Random();

            int value = random.Next(100);

            System.Console.WriteLine($"El valor random es--> {value}");

            //CHECKED y UNCHECKED;

            checked // con esto forzamos a que si ocurre un desbordamiento c# nos lanze la excepcion
            {
                int numero = int.MaxValue;//retorna el valor maximo que puede tomar un int

                int resultado = numero + 20;//deberia generar un error, pero no por que el compilador lo manejar para que no caiga la ejecucion del programa

                System.Console.WriteLine(resultado);
            }

            /*
            otra forma del checked

            int resultado = checked(numero + 20);
            aqui lanzaria la excepcion

            la misma forma si no queremos que chequee

            unchecked(numero + 20)

            SOLO FUNCIONAN CON PRIMITIVOS DE TIPO INT Y LONG
            */







        }
    }
}
