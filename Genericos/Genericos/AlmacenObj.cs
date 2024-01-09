namespace Genericos;

public class AlmacenObj<T>//el tipo generico se indica por convension la letra T
{

    private T[] datosElemento;
    private int i=0;

    public AlmacenObj(int z)
    {
        datosElemento=new T[z];
    }

    public void Agregar( T obj)
    {
        datosElemento[i]=obj;
        i++;
    }

    public T GetElemento(int i)
    {
        return datosElemento[i];
    }
}
