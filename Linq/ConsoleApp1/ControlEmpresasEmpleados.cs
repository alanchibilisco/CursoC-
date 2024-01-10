namespace ConsoleApp1;

public class ControlEmpresasEmpleados
{
    public List<EmpresaSolV101> ListaEmpresas{get;set;}

    public List<EmpleadoSolV101> ListaEmpleados{get;set;}

    public ControlEmpresasEmpleados()
    {
        ListaEmpresas=new List<EmpresaSolV101>();
        ListaEmpleados=new List<EmpleadoSolV101>();
    }

    public void GetEmpleadosCEO()
    {
        IEnumerable<EmpleadoSolV101> ceos=from empleado in ListaEmpleados where empleado.Cargo=="CEO" select empleado;

        foreach (EmpleadoSolV101 element in ceos)
        {
            element.GetInfoEmpleado();
        }
    }

    public void GetEmpleadosCTO()
    {
        IEnumerable<EmpleadoSolV101> ctos=from empleado in ListaEmpleados where empleado.Cargo=="CTO" select empleado;

        foreach (EmpleadoSolV101 element in ctos)
        {   
            element.GetInfoEmpleado();
        }
    }

    public void Test()
    {

        
        var result=from empleado in ListaEmpleados join empresa in ListaEmpresas on empleado.EmpresaId equals empresa.Id where empleado.Cargo=="CTO" select new {
            Nombre= empleado.Nombre,
            Id=empleado.Id,
            Cargo=empleado.Cargo,
            Salario=empleado.Salario,
            Empresa=empresa.Nombre

        };

        foreach (var item in result)
        {
            System.Console.WriteLine("Empleado--> Id: {0}, Nombre: {1}, Cargo: {2}, Salario: {3}, Empresa: {4}",item.Id, item.Nombre, item.Cargo, item.Salario, item.Empresa);
        }
    }
}
