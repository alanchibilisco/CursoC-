namespace ConsoleApp1;

public class Coche:Vehiculo
{
    #region Constructor
    public Coche(string Tipo):base(Tipo){}        
    #endregion

    #region Functions
    public override void Conducir()
    {
        System.Console.WriteLine($"{Tipo}: conduciendo");
    }        
    #endregion
}
