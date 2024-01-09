using Props.Empleado;

namespace Properties
{
    class App
    {
        public static void Main(string[]args)
        {
            Empleado empleado=new Empleado("Alan");

            //uso del setter
          empleado.SALARIO=1200.99;

          empleado.SalariO=-7500;

          empleado.SalariO=7500;
          //uso del getter
          /*
          empleado.SALARIO
          */
            System.Console.WriteLine($"El salario del empleado: , es: $ {empleado.SALARIO}");


        }
    }
}
