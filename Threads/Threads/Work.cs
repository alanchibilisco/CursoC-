namespace Threads;

public class Work
{


    public void Message()
    {
        System.Console.WriteLine("Desde thread 1 principal");
        Thread.Sleep(500);//duerme el thread en milisegundos;
        System.Console.WriteLine("Desde thread 1 principal");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 1 principal");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 1 principal");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 1 principal");
    }

    public void Saludo()
    {
        System.Console.WriteLine("Desde thread 2 ");
        Thread.Sleep(500);//duerme el thread en milisegundos;
        System.Console.WriteLine("Desde thread 2 ");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 2 ");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 2 ");
        Thread.Sleep(500);
        System.Console.WriteLine("Desde thread 2 ");
    }
}
