namespace Genericos;

public class Electricista:IParaEmpleados
{
     public Electricista(double salario)
    {
        this.salario=salario;
    }

    private double salario;

    public double GetSalario()
    {
        return this.salario;
    }
}
