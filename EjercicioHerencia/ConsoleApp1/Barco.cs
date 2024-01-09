namespace ConsoleApp1;

public class Barco : Vehiculo, IInterface
{
    public Barco(string Tipo):base(Tipo){}

    public override void Conducir()
    {
        System.Console.WriteLine($"{Tipo}: navegando!!");
    }

    public void Navegar(){
        System.Console.WriteLine($"{Tipo}, estamos navegando");
    }
}
