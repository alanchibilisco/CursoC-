namespace ConsoleApp1;

public class Avion:Vehiculo
{
    #region Constructor
    public Avion(string Tipo):base(Tipo){}        
    #endregion

#region Functions
    public override void Conducir()
    {
        System.Console.WriteLine($"{Tipo}: piloteando");
    }    
#endregion
}
