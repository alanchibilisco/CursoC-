namespace Delegados;

class Program
{
    public static void Main(string[]args)
    {
        /*Delegado delegado=new Delegado();

        delegado.TestSaludo();

        System.Console.WriteLine("------------------------------");

        delegado.TestDespedida();

        System.Console.WriteLine("------------------------------");

        delegado.MsgParam("Enviando mensaje delegado");*/

        List<int> listaNumeros=new List<int>();

        listaNumeros.AddRange(new int[]{1,2,3,4,5,6,7,8,9,10});

        DelegadoPredicado predicado=new DelegadoPredicado();

        predicado.GetPar(listaNumeros); 

        System.Console.WriteLine("------------------------------");

        predicado.GetPares(listaNumeros);

        List<Persona> listaPersonas=new List<Persona>();

        Persona p1=new Persona();
        p1.Nombre="Juan";
        p1.Edad=19;

        Persona p2=new Persona();
        p2.Nombre="Juana";
        p2.Edad=17;

        Persona p3=new Persona();
        p3.Nombre="Joan";
        p3.Edad=21;

        listaPersonas.AddRange(new Persona[]{p1,p2,p3});

        System.Console.WriteLine("-----------------------------");

        predicado.GetPeople(listaPersonas);

        System.Console.WriteLine("-----------------------------");

        predicado.MayorEdad(listaPersonas);

        System.Console.WriteLine("Lambdas:");

        Lambda lmbd=new Lambda();

        lmbd.GetCuadrado(3);

        lmbd.GetSuma(3,4);

        lmbd.SetMessage("\nHola LABMDA");

        /*
        AQUI CON EL USO DE EXPRESIONES LAMBDA SIMPLIFICAMOS LA CREACION DE PREDICADOS
        */

        List<Persona> mayores=listaPersonas.FindAll((persona)=>{return persona.Edad>=18;});

        mayores.ForEach((element)=>{System.Console.WriteLine("Mayor de edad: {0}", element.Nombre);});

    }
}
