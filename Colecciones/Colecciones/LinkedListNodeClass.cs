namespace Colecciones;


//https://learn.microsoft.com/es-es/dotnet/api/system.collections.generic.linkedlist-1?view=net-8.0
public class LinkedListNodeClass
{
    private LinkedList<int> linkedList;

    public LinkedListNodeClass(){
        this.linkedList=new LinkedList<int>();
    }

    public void Test()
    {
      int[] arrNum= new int[]{10,8,6,4,2,0};

      foreach (var item in arrNum)
      {
        this.linkedList.AddFirst(item);
      }  

      System.Console.WriteLine("Count--> {0}",this.linkedList.Count);
      System.Console.WriteLine("First--> {0}",this.linkedList.First.Value);
      System.Console.WriteLine("Last--> {0}",this.linkedList.Last.Value);

      System.Console.WriteLine("------------------------------------");

      foreach (var value in this.linkedList)
      {
        System.Console.WriteLine("Value--> {0}", value);
      }

      System.Console.WriteLine("Otra forma de recorrerlo pero con nodos");

      for (LinkedListNode<int> node=linkedList.First; node!=null; node=node.Next)
      {
        System.Console.WriteLine("Node Value --> {0}",node.Value);
      }
    }
}
