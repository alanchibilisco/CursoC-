namespace StructApp;

public class Empleado
{
    public double salarioBase, comision;

    public Empleado(int salarioBase, int comision)
    {
        this.salarioBase=salarioBase;
        this.comision=comision;

    }

    public override string ToString()
    {
        return string.Format("Salario y comision del empleado ${0} y ${1}", this.salarioBase, this.comision);
    }

    public void cambioSalario(Empleado emp, double incremento)
    {
        emp.salarioBase+=incremento;
        emp.comision+=incremento;
    }


}
