namespace Colecciones;

//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.list-1?view=net-8.0
public class ListClass
{
    private List<int> numberList;


    public ListClass(){
        this.numberList=new List<int>();
    }


    public void Test()
    {
        this.numberList.Add(12);
        this.numberList.Add(255);

        System.Console.WriteLine(this.numberList.Count());

        //recorrer un List
        foreach (var value in this.numberList)
        {
            System.Console.WriteLine(value);
        }

        //acceder a un valor a partir del indice
        System.Console.WriteLine(this.numberList[0]);

        this.numberList.Clear();

        System.Console.WriteLine("Cuantos elementos deseas introducir");

        int elem=int.Parse(Console.ReadLine()) ;

        for (int i = 0; i <  elem; i++)
        {
            this.numberList.Add(i);
        }

        System.Console.WriteLine(this.numberList.Count());

        foreach (var value in this.numberList)
        {
            System.Console.WriteLine(value);
        }
    }
        
       
}
