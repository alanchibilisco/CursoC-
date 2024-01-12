
using MySql.Data.MySqlClient;


namespace ConsoleApp1;


/*
LINQ ES UN LENGUAJE DE CONSULTA INTEGRADO EN C# (LANGUAJE INTEGRATED QUERY), SIRVE PARA GUARDAR Y CONSULTAR DATOS DE DIFERENTES ORIGENES DE DATOS
*/
public class Program
{
    public static void Main(string[] args)
    {
        /*int[] arrNum=new int[]{1,2,3,4,5,6,7,8,9,10};

        System.Console.WriteLine("Numeros pares");*/

        /*List<int> numPares=new List<int>();

        foreach (int value in arrNum)
        {
            if (value%2==0)
            {
                numPares.Add(value);
            }
        }*/

        /*numPares.ForEach((element)=>{
            System.Console.WriteLine("Elemento--> {0}",element);
        });*/

        //USO DE LINQ, con esto simplificamos el tener que recorrer el array finltrandolo y almacenando los datos en una List para recien luego recorrerla e imprimir los valores
        //LINQ se combina con las expresiones lambda 
        /*IEnumerable<int> numPares=from value in arrNum where value%2==0 select value;//esto es linq utiliza sintaxis similar a la de mysql;

        foreach (int value in numPares)
        {
            System.Console.WriteLine("Value--> {0}", value);
        }*/

        //---------SEGUNDA PARTE DE LINQ CON OBJ----------------------

        /*Empresa empresa1=new Empresa("Empresa 1");
        Empresa empresa2=new Empresa("Empresa 2");

        Empleado alan=new Empleado(empresa1, "Alan", 1250);
        Empleado tomas=new Empleado(empresa1, "Tomas", 2556);
        Empleado leo=new Empleado(empresa2, "Leo",1250);
        Empleado gaston=new Empleado(empresa2,"Gaston",1250);

        System.Console.WriteLine("El empleado {0}, pertenece a la empresa {1}, y posee un salario de {2}", alan.NOMBRE, alan.EMPRESA.NOMBRE, alan.SALARIO);*/
        /*ControlEmpresasEmpleados almacenamiento = new ControlEmpresasEmpleados();

        EmpresaSolV101 google = new EmpresaSolV101(1, "Google");

        EmpresaSolV101 meta = new EmpresaSolV101(2, "Meta");

        almacenamiento.ListaEmpresas.Add(google);
        almacenamiento.ListaEmpresas.Add(meta);

        EmpleadoSolV101 alan = new EmpleadoSolV101(1, "Alan", "CTO", 1250, 1);
        EmpleadoSolV101 tomas = new EmpleadoSolV101(2, "Tomas", "CEO", 2550, 1);
        EmpleadoSolV101 leo = new EmpleadoSolV101(3, "Leo", "CEO", 2535, 2);
        EmpleadoSolV101 gaston = new EmpleadoSolV101(4, "Gaston", "CTO", 1243, 2);

        almacenamiento.ListaEmpleados.Add(alan);
        almacenamiento.ListaEmpleados.Add(tomas);
        almacenamiento.ListaEmpleados.Add(leo);
        almacenamiento.ListaEmpleados.Add(gaston);

        almacenamiento.GetEmpleadosCEO();

        System.Console.WriteLine("-------------------------------------------");

        almacenamiento.GetEmpleadosCTO();

        System.Console.WriteLine("-------------------------------------------");

        almacenamiento.Test();*/


        /* PARA UTILIZAR LE PAQUETE en la carpeta contenedora del proyecto instalar el paquete con dotnet add package MySql.Data */
        System.Console.WriteLine("Probando conexion a bbdd");
        string connectString = "Server=127.0.0.1;Port=3306;Database=c_sharp;User ID=alan;Password=alan;SSL Mode=None;";
        //string connectString="Server=127.0.0.1;Port=3306;Database=c_sharp;User ID=alan;Password=alan;";

        using (MySqlConnection connection = new MySqlConnection(connectString))
        {
            try
            {
                connection.Open();
                string dbName = connection.Database;

                System.Console.WriteLine("Conectado a BBDD--> {0}", dbName);
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Error--> {0}", e);
                System.Console.WriteLine("Cerrando la conexion");
                connection.Close();

            }
        };


        BBDD repository=new BBDD();

        //repository.NewEmpresa("Meta");
        //repository.NewEmpresa("Google");

        /*repository.NewCargo("Gerente");
        repository.NewCargo("Director");
        repository.NewCargo("Secretario");*/

        repository.GetEmpresas();

        /*IntoEmpresa(new EmpresaDB{nombre="Meta"});-->Esto arroja el siguiente error:
        Error--> System.TypeLoadException: Method 'GetServiceProviderHashCode' in type 'ExtensionInfo' from assembly 'MySql.Data.EntityFrameworkCore, Version=8.0.22.0, Culture=neutral, PublicKeyToken=c5687fc88969c44d' does not have an implementation.
   at MySql.Data.EntityFrameworkCore.Infrastructure.Internal.MySQLOptionsExtension.get_Info()
   at Microsoft.EntityFrameworkCore.DbContextOptions.GetHashCode()
   at System.Collections.Concurrent.ConcurrentDictionary`2.GetOrAdd[TArg](TKey key, Func`3 valueFactory, TArg factoryArgument)
   at Microsoft.EntityFrameworkCore.Internal.ServiceProviderCache.GetOrAdd(IDbContextOptions options, Boolean providerRequired)
   at Microsoft.EntityFrameworkCore.DbContext.get_ContextServices()
   at Microsoft.EntityFrameworkCore.DbContext.get_InternalServiceProvider()
   at Microsoft.EntityFrameworkCore.DbContext.get_DbContextDependencies()
   at Microsoft.EntityFrameworkCore.DbContext.Microsoft.EntityFrameworkCore.Internal.IDbContextDependencies.get_StateManager()
   at Microsoft.EntityFrameworkCore.Internal.InternalDbSet`1.EntryWithoutDetectChanges(TEntity entity)
   at Microsoft.EntityFrameworkCore.Internal.InternalDbSet`1.Add(TEntity entity)
   at ConsoleApp1.Program.IntoEmpresa(EmpresaDB empresa) in /home/alan/CursoC#/Linq/ConsoleApp1/Program.cs:line 125
        */




    }


    public static void IntoEmpresa(EmpresaDB empresa)
    {
        try
        {
            using var context = new AppDbContext();
            context.Empresas.Add(empresa);
            var row = context.SaveChanges();
            System.Console.WriteLine("Insert Into--> {0}", row);
        }
        catch (System.Exception ex)
        {
            System.Console.WriteLine("Error--> {0}", ex);

        }


    }
}