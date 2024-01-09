namespace ConsoleApp1;

public class HandleFile
{
    StreamReader file=null;
    int contador=0;
    string line;

    public HandleFile()
    {
        file=new StreamReader(@"/home/alan/CursoC#/repos.txt");
        while ((line=file.ReadLine())!=null)
        {
            System.Console.WriteLine(line);
            contador++;
        }
    }

    public void Mensaje()
    {
        System.Console.WriteLine("Se leyeron {0} lineas.", contador);
    }

    /*SINTAXIS DESCTRUCTOR ~<NOMBRE-CLASE>(){}
    -LOS DESTRUCTORES SOLO SE USAN EN CLASES
    -CADA CLASE SOLO PUEDE TENER UN DESTRUCTOR
    -LOS DESTRUCTORES NO SE HEREDAN NI SE SOBRECARGAN
    -LOS DESTRUCTORES NO SE LLAMAN. SON INVOCADOS AUTOMATICAMENTE
    -LOS DESTRUCTORES NO TIENE MODIFICADORES DE ACCESO NI PARAMETROS    
    */

    ~HandleFile()
    {
        //si fuese una conexion a bbdd aqui es donde deberia cerrarla
        file.Close();
    }
}
