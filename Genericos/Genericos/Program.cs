namespace Genericos;

public class App
{
    public static void Main(string[] args)
    {
        //CUANDO SE INSTANCIA UN CLASE GENERICA SE DEBE COLOCAR EN LA DECLARACION DEL TIPO Y CUANDO SE CREA LA INSTANCIA EL TIPO QUE OCUPARA EL LUGAR DEL GENERICO
        AlmacenObj<Empleado> almacen=new AlmacenObj<Empleado>(4);

        /*almacen.Agregar("Juan");
        almacen.Agregar("Alan");
        almacen.Agregar("Jose");
        almacen.Agregar("Julio");*/

        almacen.Agregar(new Empleado(1500));
        almacen.Agregar(new Empleado(1245));
        almacen.Agregar(new Empleado(2567));
        //aqui vemos el primer problema que es tener que hacer casting
        /*string nombrePersona=(string)almacen.getElemento(2);*/

        System.Console.WriteLine(almacen.GetElemento(2).GetSalario());


        GenericoConRestriccion<IParaEmpleados> storage= new GenericoConRestriccion<IParaEmpleados>(5);

        storage.Agregar(new Empleado(2679));
        storage.Agregar(new Director(5768));
        storage.Agregar(new Secretaria(3421));
        storage.Agregar(new Electricista(4763));

        System.Console.WriteLine(storage.GetEmpleado(3).GetSalario());
    }
}