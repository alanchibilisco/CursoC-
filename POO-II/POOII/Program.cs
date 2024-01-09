// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using POOII;
using static System.Math;//importar todos los metodos static de la clase Math, no es recomendable en las apps grandes
namespace App
{
    class App
    {
        static void Main(string[]args){
            Console.WriteLine("Hola Tomy");
            RealizarTarea();

            double raiz=Sqrt(9);

            double potencia=Pow(3,4);

            System.Console.WriteLine($"Raiz--> {raiz}");
            System.Console.WriteLine($"POtencia--> {potencia}");

            //clases anonimas
            //las clases anonimas no piden el tipo de dato de los atributos
             var anonima = new {name="Alan", surName="Chibilisco"};

             System.Console.WriteLine($"Prop anonima--> {anonima.name}, {anonima.surName}");
            //el compilador al ver que el nuevo objeto tiene las mismas propiedas, en el mismo orden establece que pertenecen a la misma clase
             var anonima2=new{name="Meli", surName="Santillan"};
            /*
            las clases anonimas deben tener todos los campos publicos, tienen q estar iniciados, no pueden ser static y no se pueden definir metodos;
            */    

        }

        static void RealizarTarea()
        {
            Punto origin=new(5,7);
            Punto destiny=new Punto();
            double result=destiny.DistanciaHasta(origin);

            System.Console.WriteLine($"La distancia entre los puntos es: {result}"); 
            Console.WriteLine($"Cantidad de objetos creados: {Punto.GetContadorDeObjetos()}");                                   

        }
    }
}
