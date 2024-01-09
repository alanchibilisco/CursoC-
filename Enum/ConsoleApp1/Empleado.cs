namespace ConsoleApp1;

public class Empleado
{
    private double salario,bonus;

    public Empleado(double salario, double bonus){
        this.salario=salario;
        this.bonus=bonus;
    }

    public override string ToString()
    {
        return $"El salario bruto del empleado es: $ {this.salario+this.bonus}";
    }
}
