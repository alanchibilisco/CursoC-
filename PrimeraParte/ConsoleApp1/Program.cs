// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Mundo C#");

            Console.WriteLine("Este es otro mensaje");

            int edad;

            edad=35;
        
            Console.WriteLine("El valor de edad es --> "+edad);
            //interpolacion de strings
            Console.WriteLine($"El valor de edad es --> {edad}");

            //declaracion implicita de variables, en tiempo de ejecucion se asigna el tipo, NO PERMITE REASIGNAR EL VALOR DE LA MISMA

            var otraEdad=30;
            Console.WriteLine($"Otra edad--> {otraEdad}");

            //consveriones de tipo explicita o casting

            double temp=34.5;
            int tempInt=(int) temp;

            //converion implicita, siempre dentro del mismo rango de tipos

            int habCiudad=100;

            long habCiudadLong=habCiudad;

            float pesoMat=5.32F;
            double pesoMatDouble=pesoMat;

            //conversiones de tipo, de texto a numero y viceversa

            string age="35";
            int parseado=int.Parse(age);
            string parse=parseado.ToString();
            int longitud=parse.Length;

            //pedir por consola el ingreso de un valor

            //Console.ReadLine();
            
            //CONSTANTES

            // const [tipo-dato] [NOMBRE] = [valor]; si o si declara e inicializar en la misma linea, por convencion el nombre va todo en mayuscula

            const int VALOR=5;
            const int VALOR2=7;
            System.Console.WriteLine("este es el valor de VALOR-->{0}{1}", VALOR, VALOR2);//esta forma permite pasarle vario valores al metodo writeline, recordar que hay q indicar los parametros que queremos que se impriman en pantalla


            //METODOS

            /* tipo-dato-devuelto [nombre-metodo] ([parametros]){
              cuerpo metodo
            }*/

            int suma(int num1, int num2){
                return num1 + num2;
            };

            System.Console.WriteLine($"Metodo suma {suma(7,5)}");


            void hello(){
                System.Console.WriteLine("Hello world");
            };

            hello();
        }
    }
}
