// See https://aka.ms/new-console-template for more information
namespace LanzExcepciones
{
    class App
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Introduce el numero del mes");
            int mes=int.Parse(Console.ReadLine());
            try
            {
            System.Console.WriteLine(NombreMes(mes));                
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine($"Se produjo el siguiente error--> {e}");                
            }
            System.Console.WriteLine("Aqui continua la ejecucion del programa");

        }

        public static string NombreMes(int mes)
        {
            switch (mes)
            {
                case 1:
                return "Enero";
                case 2:
                return "Febrero";
                case 3:
                return "Marzo";
                case 4:
                return "Abril";
                case 5:
                return "Mayo";
                case 6:
                return "Junio";
                case 7:
                return "Julio";
                case 8:
                return "Agosto";
                case 9:
                return "Septiembre";
                case 10:
                return "Octubre";
                case 11:
                return "Noviembre";
                case 12:
                return "Diciembre";               
                default:
                //return "No ingreso un numero valido";
                string paramName="Debe ingresar un numero entre 1 y 12";
                throw new ArgumentOutOfRangeException(paramName);
            }
            /*
            SWITCH EXPRESION
             return mes switch
            {
                1 => "Enero",
                2 => "Febrero",
                3 => "Marzo",
                4 => "Abril",
                5 => "Mayo",
                6 => "Junio",
                7 => "Julio",
                8 => "Agosto",
                9 => "Septiembre",
                10 => "Octubre",
                11 => "Noviembre",
                12 => "Diciembre",
                _ => throw new ArgumentOutOfRangeException("Debe ingresar un numero entre 1 y 12"),//return "No ingreso un numero valido";
            };
            */
        }
    }
}
