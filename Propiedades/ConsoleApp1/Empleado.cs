namespace Props.Empleado
{
public class Empleado
{
        private string nombre;
        private double salario;

        public Empleado(string nombre)
    {
        this.nombre = nombre;
    }

    private double EvaluaSalario(double salario)
    {
        if(salario>0){
            return salario;
        }else{
            System.Console.WriteLine("El salario no puede ser un numero negativo, se establecera por defecto en 0");
            return 0;
        }
    }

    /*CREACION DE PROPIEDADES, SINTAXIS [MOD.ACCESOS] [TIPO] <NOMBRE-MAYUS> { 
        get{return field;}
        set {field=value;}
    }*/

    public double SALARIO
        {
            get {return this.salario; }
            set { this.salario=EvaluaSalario(value); }

        }

    /*Expresiones boddied u operador lambda

    SINTAXIS [MOD.ACCESOS] [TIPO] <NOMBRE-MAYUS> {
        get => this.field;
        set => this.field=value;
    }    
    */

    public double SalariO
    {
        get=>this.salario;
        set=>this.salario=EvaluaSalario(value);
    }
        /*public void SetSalario(double salario)
        {
            if (salario > 0)
            {
                this.salario = salario;
                
            }
            else
            {
                System.Console.WriteLine("El salario deber no puede ser negativo, se establecera por defecto el salario en 0");
                this.salario = 0;
            }
        }

        public double GetSalario()
        {
            return this.salario;
        }*/
    }
}



