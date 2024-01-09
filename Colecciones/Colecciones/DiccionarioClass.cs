namespace Colecciones;

public class DiccionarioClass
{

    private Dictionary<int, string> diccionario;

    public DiccionarioClass()
    {
        this.diccionario = new Dictionary<int, string>();
    }

    public void Test()
    {
        this.diccionario.Add(1, "Alan");
        this.diccionario.Add(2, "Leo");
        this.diccionario.Add(3, "Gaston");
        this.diccionario.Add(4, "Tomas");

        System.Console.WriteLine("Recorremos el diccionario a travez de las key y value");

        foreach (KeyValuePair<int, string> element in this.diccionario)
        {
            System.Console.WriteLine("Key--> {0}, Value--> {1}", element.Key, element.Value);
        }
        //otra forma de agregar elementos dentro del diccionario
        System.Console.WriteLine("-----------------------------------");
        this.diccionario[5] = "Marcelo";
        foreach (KeyValuePair<int, string> element in this.diccionario)
        {
            System.Console.WriteLine("Key--> {0}, Value--> {1}", element.Key, element.Value);
        }
        System.Console.WriteLine("-----------------------------------");
        //eliminar un elemento del diccionario
        this.diccionario.Remove(5);
        foreach (KeyValuePair<int, string> element in this.diccionario)
        {
            System.Console.WriteLine("Key--> {0}, Value--> {1}", element.Key, element.Value);
        }


    }
}
