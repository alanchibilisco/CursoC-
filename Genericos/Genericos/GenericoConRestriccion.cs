namespace Genericos;


//la restriccion se declara despues del tipo generico con la declaracion where T:[RESTRICCION], esta restriccion es declarar que el tipo pertenece a una clase o interfaz
public class GenericoConRestriccion<T> where T:IParaEmpleados
{
    private int i=0;
    private T[] datosEmpleado;

    public GenericoConRestriccion(int z)
    {
        datosEmpleado=new T[z];
    }

    public void Agregar(T obj)
    {
        this.datosEmpleado[i]=obj;
        this.i++;
    }

    public T GetEmpleado(int y)
    {
        return this.datosEmpleado[y];
    }
}
