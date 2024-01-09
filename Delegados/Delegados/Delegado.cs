namespace Delegados;
/*LOS DELEGAGOS SON FUNCIONES QUE DELEGAN TAREAS EN OTRAS FUNCIONES, UN DELEGADO ES UNA REFERENCIA A UN METODO, SIRVEN PARA LLAMAR A EVENTOS, CODIGO MUY REUTILIZABLE */

/*SINTAXIS delegate TIPO <NOMBRE>(parametros)*/

/*LOS DELEGADOS SOLO PUEDEN LLAMAR A METODOS QUE TIENEN LA MISMA ESTRUCTURA, ES DECIR QUE RESPETEN EL TIPO DE VALOR DEVUELTO Y CANTIDAD Y TIPO DE PARAMETROS*/
public class Delegado
{

    //definicion de un delegado

    public Delegado(){

    }

    //creacion de delegados sin parametros 
    private delegate void SaludoDelegado();
    private delegate void MsjDespedidaDelegado();

    SaludoDelegado sdDelegado = new SaludoDelegado(Msj.Saludo);

    MsjDespedidaDelegado msjDespedidaDelegado=new MsjDespedidaDelegado(MsjDespedida.Despedida);
    
    public void TestSaludo(){
        sdDelegado();        
    }

    public void TestDespedida(){
        msjDespedidaDelegado();
    }

    //creacion de delegados con parametros

    private delegate void MsjParam(string msg);

    MsjParam param=new MsjParam(MsjConParam.Msj);

    public void MsgParam(string msg){
        param(msg);
    }
}



public class Msj
{
    public static void Saludo()
    {
        System.Console.WriteLine("Hola acabo de llegar");
    }
}

public class MsjDespedida
{
    public static void Despedida()
    {
        System.Console.WriteLine("Hola ya me voy, chau.");
    }
}

public class MsjConParam{
    public static void Msj(string msg){
        System.Console.WriteLine("Mensaje recibido: {0}", msg);
    }
}