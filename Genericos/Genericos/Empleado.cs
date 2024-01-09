namespace Genericos;

public class Empleado:IParaEmpleados
{
    private double salario;

    public Empleado(double salario)
    {
        this.salario=salario;
    }

    public double GetSalario()
    {
        return this.salario;
    }
}
