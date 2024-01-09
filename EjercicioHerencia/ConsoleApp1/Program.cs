// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

namespace Main
{
    class App
    {
        public static void Main(string[]args)
        {
            Avion avion=new("Aeroplano");
            Coche coche=new Coche("PickUp");
            Barco barco=new Barco("Lancha");

            avion.ArrancarMotor();
            coche.ArrancarMotor();
            barco.ArrancarMotor();

            avion.Conducir();
            coche.Conducir();
            barco.Conducir();            

            barco.Navegar();

            avion.PararMotor();
            coche.PararMotor();
            barco.PararMotor();
        }
    }
}