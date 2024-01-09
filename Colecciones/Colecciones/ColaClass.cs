namespace Colecciones;

public class ColaClass
{
    private Queue<int> colaNumeros;

    public ColaClass()
    {
        this.colaNumeros= new Queue<int>();//se crea una cola con capacidad predeterminada;

        //agregar elemento a la cola        
    }

    public void Test()
    {
        this.colaNumeros.Enqueue(1);
        this.colaNumeros.Enqueue(2);
        this.colaNumeros.Enqueue(3);
        this.colaNumeros.Enqueue(4);
        this.colaNumeros.Enqueue(5);

        System.Console.WriteLine("Valores dentro de la Cola:");
        foreach (var value in this.colaNumeros)
        {
            System.Console.WriteLine("Value--> {0}",value);
        }
        System.Console.WriteLine("Eliminando un elemento de la cola");

        System.Console.WriteLine("Eliminamos el primero elemento de la cola--> {0}", this.colaNumeros.Dequeue());//tener en cuenta q elimina y retorna el valor eliminado

        System.Console.WriteLine("Obtener el primer elemento de una cola sin eliminarlo--> {0}", this.colaNumeros.Peek());

        foreach (var value in this.colaNumeros)
        {
            System.Console.WriteLine("Value--> {0}",value);
        }
    }
}
