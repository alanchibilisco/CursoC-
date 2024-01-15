namespace Threads;

public class Program
{
    public static void Main(string[] args)
    {
        /*Work main=new Work();
        //De la siguiente manera los threads se ejecutan en orden aleatorio;
        Thread Tmain=new Thread(main.Message);// creamos un nuevo threads
        Tmain.Start();//lo iniciamos
        //sincronizando threads
        Tmain.Join();
        //main.Message();

        Thread Ttwo=new Thread(main.Saludo);
        Ttwo.Start();
        Ttwo.Join();
        //main.Saludo();

        Thread Tthree = new Thread(main.Saludo);
        Tthree.Start();
        Tthree.Join();

        //sincronizacion y bloqueos de threads metodos join y lock*/

        /*CtaBcria banco=new CtaBcria(10000);

        Thread[] personas=new Thread[15];

        for (int i = 0; i < personas.Length; i++)
        {
            Thread t=new Thread(banco.RetiraEftvo);//Thread no permite que le pasemos metodos que reciben parametros, pero si le podemos pasar una funcion lambda
            t.Name=i.ToString();
            personas[i]=t;
        }

        for (int i = 0; i < personas.Length; i++)
        {
            personas[i].Start();//iniciamos los threads
            personas[i].Join();//sincronizamos los threads
        }*/


        /*// TASK COMPLETION SOURCE

        var completedTask1 = new TaskCompletionSource<bool>();
        var completedTask2 = new TaskCompletionSource<bool>();

        //creacion de un thread con lambda
        var t1 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Thread 1");
                Thread.Sleep(1000);
            }

            //establecer que se termino la tarea del thread;

            completedTask1.TrySetResult(true);
        });

        var t2 = new Thread(() =>
        {            
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Thread 2");
                Thread.Sleep(1000);
            }

            completedTask2.TrySetResult(true);
        });

        var t3 = new Thread(() =>
        {
            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Thread 3");
                Thread.Sleep(1000);
            }
        });

        t1.Start();
        //con esto compruebo si la tarea del thread 1 ya se termino, solo cuando este terminada pasara al siguiente thread
       
        var result1=completedTask1.Task.Result;
        t2.Start();

         var result2=completedTask2.Task.Result;
        
        t3.Start();*/

    //POOL de threads
    for (int i = 0; i < 100; i++)
    {
        /*Thread t=new Thread(EjecutaTarea);
        t.Start();*/
        //con esto creo un pool de threads el metodo, sirve para reutilizar threads, crea una cola en la que cuando un thread se libera se ejecuta otra tarea, el metodo recibe una callback con parametro del tipo obj
        ThreadPool.QueueUserWorkItem(EjecutaTarea, i);
    }

    Console.ReadLine();

    }


    public static void EjecutaTarea(object o)
    {
        int nTarea=(int)o;
        System.Console.WriteLine("Thread N° {0}, ha comenzado la tarea N° {1}",Thread.CurrentThread.ManagedThreadId, nTarea );
        Thread.Sleep(1000);
        System.Console.WriteLine("Thread N° {0}, ha terminado la tarea N°{1}", Thread.CurrentThread.ManagedThreadId, nTarea);
    }
}
