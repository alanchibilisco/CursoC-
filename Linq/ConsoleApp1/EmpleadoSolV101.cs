using System.Data.Common;

namespace ConsoleApp1;

public class EmpleadoSolV101
{
    public int Id {get;set;}
    public string Nombre{get;set;}

    public string Cargo{get;set;}

    public double Salario{get;set;}

    public int EmpresaId{get;set;}

    public EmpleadoSolV101(int Id, string Nombre, string Cargo, double Salario, int EmpresaId)
    {
        this.Id=Id;
        this.Nombre=Nombre;
        this.Cargo=Cargo;
        this.Salario=Salario;
        this.EmpresaId=EmpresaId;
    }

    public void GetInfoEmpleado()
    {
        System.Console.WriteLine("Empleado {0}, con id {1}, con cargo {2}, con salario {3}, pertecneciente a la empresa {4}", this.Nombre, this.Id, this.Cargo, this.Salario, this.EmpresaId);
    }
}
