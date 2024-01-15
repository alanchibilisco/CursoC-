using System.Linq.Expressions;

namespace Threads;

public class CtaBcria
{

    double Saldo {get;set;}

    object obj=new object();

    public CtaBcria(double Saldo)
    {
        this.Saldo=Saldo;
    }


    public double Extraccion(double cantidad)
    {
        if(this.Saldo<cantidad)
        {
            System.Console.WriteLine("Saldo insuficiente, Thread: {0}", Thread.CurrentThread.Name); //obtengo el nombre del thread en ejecucion
            return this.Saldo;
        }

        if(this.Saldo == 0)
        {
            System.Console.WriteLine("No tiene saldo, Thread: {0}", Thread.CurrentThread.Name);
            return this.Saldo;
        }
        //esta es la porcion de codigo que hay q bloquear para que mientras se este ejecutando los demas threads se bloqueen, se utiliza el metodo lock(obj)
        lock(obj){
            if (this.Saldo>=cantidad)
        {
            System.Console.WriteLine("Extrajo $ {0}, Saldo restante: $ {1}, Thread: {2}", cantidad, this.Saldo-cantidad, Thread.CurrentThread.Name);

            this.Saldo-=cantidad;

        }
        }
        

        return this.Saldo;
    }

    public void RetiraEftvo()
    {
        System.Console.WriteLine("Operando Thread: {0}", Thread.CurrentThread.Name);
        for (int i = 0; i < 4; i++)
        {
            Extraccion(500);
            
        }
    }
}
