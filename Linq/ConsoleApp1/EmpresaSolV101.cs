namespace ConsoleApp1;

public class EmpresaSolV101
{
    public int Id {get;set;}

    public string Nombre {get;set;}

    public EmpresaSolV101(int Id, string Nombre){
        this.Id=Id;
        this.Nombre=Nombre;
    }

    public void GetInfoEmpresa()
    {
        System.Console.WriteLine("Empresa {0} con Id {1}", this.Nombre, this.Id);
    }

}
