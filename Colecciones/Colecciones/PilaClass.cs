namespace Colecciones;

public class PilaClass
{

    private Stack<int> pilaNumeros;

    public PilaClass()
    {
        this.pilaNumeros=new Stack<int>();
        
    }

    public void Test()
    {
        this.pilaNumeros.Push(1);
        this.pilaNumeros.Push(2);
        this.pilaNumeros.Push(3);
        this.pilaNumeros.Push(4);

        System.Console.WriteLine("Recorremos la pila/stack");

        foreach (var value in this.pilaNumeros)
        {
            System.Console.WriteLine("Value --> {0}",value);
        }

        System.Console.WriteLine("Obteniendo el ultimo elemnto ingresado sin eliminarlo--> {0}", this.pilaNumeros.Peek());

        System.Console.WriteLine("Eliminando el ultimo elemento ingresado cuyo valor es--> {0}", this.pilaNumeros.Pop());

        System.Console.WriteLine("La pila luego de eliminar un elemento");

        foreach (var value in this.pilaNumeros)
        {
            System.Console.WriteLine("Value --> {0}",value);
        }

    }

}
