namespace Genericos;

public class Secretaria:IParaEmpleados
{
 public Secretaria(double salario)
    {
        this.salario=salario;
    }

    private double salario;

    public double GetSalario()
    {
        return this.salario;
    }
}
