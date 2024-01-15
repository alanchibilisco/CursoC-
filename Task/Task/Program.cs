using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Tasks;

public class Program
{

    //campo para parallel

    private static int acumulador=0;
    public static void Main(string[] args)
    {
        //LAS TASK SE POSICIONAN POR ENCIMA DE LOS THREADS, CREA UN POOL DE THREADS PARA OPTIMIZAR LOS RECURSOS DEL PROCESADOR, una taks es un promesa, el thread es la herramienta para lograr la task
        //creo la tarea
        /*Task tarea=new Task(Tarea);

        //inicio la tarea
        tarea.Start();*/
        //esta es otra forma de declarar una tak e iniciarla, directamente con el metodo run
        //Task tarea=Task.Run(()=>Tarea());

        /*Task tarea2= new Task(()=>{
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Tarea 2, ciclo N° {0}, asignado a thread N° {1}", i, Thread.CurrentThread.ManagedThreadId);
            }
        });


        tarea2.Start();*/

        /*Task tarea2=Task.Run(()=>{
            Tarea2();
        });*/


        //TASK CONTINUES

        //Task tarea2=tarea.ContinueWith(Tarea2);



        //PRIORIDADES de TASK

        //EjecutaTodo();
        //Console.ReadLine();

        //CLASE PARALLEL 

        /*for (int i = 0; i < 100; i++)
        {
            TareaCParallel(i);
            System.Console.WriteLine($"I: {i}. Acumulador: {acumulador}. Tarea realizada por Thread {Thread.CurrentThread.ManagedThreadId}");
        }*/
        //SINTAXIS
        //Parallel.For(0,100,(i)=>{TareaCParallel(i);});

        //CANCELACION DE TASKS

        //crear un token de cancelacion
        CancellationTokenSource token=new CancellationTokenSource(); //apuntador 

        CancellationToken cancelToken=token.Token; //este es quien realmente cancela la tarea;



        Task t=Task.Run(()=>{TareaPCancelacion(cancelToken);});

        for (int i = 0; i < 100; i++)
        {
            acumulador+=30;
            Thread.Sleep(1000);

            if (acumulador>100)
            {
                //con esta instruccion se propaga la cancelacion de la tarea;
                token.Cancel();
                //aqui rompemos el ciclo for
                break;
            }
        }

        Thread.Sleep(1000);
        System.Console.WriteLine("Acumulador--> {0}", acumulador);
        Console.ReadLine();
    }


    public static void EjecutaTodo()
    {
        var t1 = Task.Run(() => { Tarea(); });
        //sirve para indicar que se tiene que completar la tarea para recien continuar
       t1.Wait();
        var t2 = Task.Run(() => { Tarea2(); });
        //se declara para esperar a que otras tareas se completen
        //Task.WaitAll(t1, t2);
        //se declara para esperar a que cualqueira de las dos tareas esten completadas
        //Task.WaitAny(t1, t2);

        
        var t3 = Task.Run(() => { Tarea3(); });

        
    }

    public static void TareaCParallel(int i){
        if (acumulador%2==0)
        {
            acumulador+=i;
            Thread.Sleep(100);
        }else{
            acumulador-=i;
            Thread.Sleep(100);
        }
        System.Console.WriteLine($"I: {i}. Acumulador: {acumulador}. Tarea realizada por Thread {Thread.CurrentThread.ManagedThreadId}");

    }

//para que una tarea se cancele tiene que poder recibir el cancellation token
    public static void TareaPCancelacion(CancellationToken token)
    {
        for (int i = 0; i < 100; i++)
        {
            acumulador++;
            int t=Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(1000);
            System.Console.WriteLine("Ejecutando tarea el thread: {0}", t);
            System.Console.WriteLine("Acumulador --> {0}",acumulador);
            if (token.IsCancellationRequested)
            {
                //acumulador=0;
                //aqui devolvemos el flujo de ejecucion al metodo principal
                return;
            }
        }
    }


    public static void Tarea()
    {
        for (int i = 0; i < 5; i++)
        {
            var miThread = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(1000);
            System.Console.WriteLine("T:1-->Ciclo N° {0}, asignado a Thread N°: {1}", i, miThread);
        }
    }


    public static void Tarea2()
    {
        for (int i = 0; i < 5; i++)
        {
            var miThread = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(500);
            System.Console.WriteLine("T:2-->Ciclo N° {0}, asignado a Thread N°: {1}", i, miThread);
        }
    }

    public static void Tarea3()
    {
        for (int i = 0; i < 5; i++)
        {
            var miThread = Thread.CurrentThread.ManagedThreadId;
            Thread.Sleep(500);
            System.Console.WriteLine("T:3-->Ciclo N° {0}, asignado a Thread N°: {1}", i, miThread);
        }
    }
}