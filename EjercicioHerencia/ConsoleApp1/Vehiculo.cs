namespace ConsoleApp1;

public class Vehiculo
{
    #region fields
    protected string Tipo {get; set;}       
    #endregion

    #region Constructor
        public Vehiculo(string Tipo)
        {
            this.Tipo=Tipo;
        }
    #endregion

    #region Functions
        public void ArrancarMotor()
        {
            System.Console.WriteLine($"{Tipo}: arrancando motor!!");
        }

        public void PararMotor()
        {
            System.Console.WriteLine($"{Tipo}: deteniendo motor!!");
        }

        public virtual void  Conducir(){}
    #endregion    
}
