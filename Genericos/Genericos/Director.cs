namespace Genericos;

public class Director:IParaEmpleados
{
    public Director(double salario)
    {
        this.salario=salario;
    }
    
    private double salario;

    public double GetSalario()
    {
        return this.salario;
    }
}
