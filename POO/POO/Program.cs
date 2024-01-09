// See https://aka.ms/new-console-template for more information


using System.Runtime.CompilerServices;

namespace POO
{
    class POO
    {
        static void Main(string[] args)
        {

            Circulo nuevoCirculo = new();
            double area = nuevoCirculo.CalculoArea(12);
            System.Console.WriteLine(area);

            ConversorEuroDolar conv = new ConversorEuroDolar();

            double valor = conv.Conversor(100);
            System.Console.WriteLine($"El valor convertido es--> {valor}");

            Coche car=new Coche();

            System.Console.WriteLine(car.GetInfoCoche());

            
            
        }
    }


    class Circulo
    {
        private const double PI = 3.1416;
        public double CalculoArea(int radio)
        {
            return PI * Math.Pow(radio, 2);
        }
    }

    class ConversorEuroDolar
    {
        private double euro = 1.253;

        public double Conversor(double cantidad)
        {
            return euro * cantidad;
        }

        public void SetEuro(double valor)
        {
            if (valor > 0)
            {
                euro = valor;

            }
        }
    }

    class Coche
    {
       private int ruedas { get; set;}
       private double largo;
       private double ancho;
       private bool climatizador { get; set;}
       private string tapizado;

       public Coche(double largo, double ancho, bool climatizador, string tapizado)
       {
        ruedas=4;
        this.largo=largo;
        this.ancho=ancho;
        this.climatizador=climatizador;
        this.tapizado=tapizado;
       }

       public Coche()
       {
        ruedas=4;
        largo=2300.5;
        ancho=4500.0;
        climatizador=false;
        tapizado="Tela";
       }


        public string GetInfoCoche()
        {
            return $"Info coche: Ruedas: {ruedas}, Largo: {largo}, Ancho: {this.ancho}, Climatizador: {this.climatizador}, Tapizado: {this.tapizado}";
        }
        
        public void SetClimatizador(bool value)
        {
            climatizador=value;
        }
    }
}
