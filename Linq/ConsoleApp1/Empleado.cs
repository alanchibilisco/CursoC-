namespace ConsoleApp1;

public class Empleado
{
    private Empresa empresa;
    private string nombre;
    private double salario;

    public Empleado(Empresa empresa, string nombre, double salario)
    {
        this.empresa=empresa;
        this.nombre=nombre;
        this.salario=salario;
    }

    public Empresa EMPRESA{
        get=>this.empresa;
    }

    public string NOMBRE
    {
        get=>this.nombre;
        set=>this.nombre=value;
    }

    public double SALARIO
    {
        get=>this.salario;
        set=>this.salario=value>0?value:0;
    }


}
