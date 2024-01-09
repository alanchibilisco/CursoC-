// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



namespace Condicionales
{
    class App
    {
        static void Main(string[] args)
        {
            //declaracion de booleanos

            bool state = false;

            int edad = 15;

            System.Console.WriteLine("Vamos a evaluar si eres mayor de edad");

            if (edad >= 18)
            {
                System.Console.WriteLine("Eres mayor de edad");
            }
            else if (edad >= 15)
            {
                System.Console.WriteLine("Te falta poco para ser mayor de edad");
            }
            else
            {
                System.Console.WriteLine("Aun no posees la edad suficiente");
            }

            int result= string.Compare("Alan", "alana", true);//retorna 0 si coinciden y retorna -1 si no coinciden
            System.Console.WriteLine(result);

            //SWITCH CASE
            string caso="Sabado";

            switch (caso)
            {
                case "Lunes":
                case "Martes":
                case "Miercoles":
                case "Jueves":
                case "Viernes":
                System.Console.WriteLine("Es dia de semana");
                break;
                default:
                System.Console.WriteLine("Es fin de semana");
                break;
            }
        }
    }
}
