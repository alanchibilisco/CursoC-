namespace ClassLibrary1;

public class Class1
{
    string name;

    public Class1(string name)
    {
        this.name=name;
    }

    public string HelloWorld()
    {
        return $"Hola soy --> {this.name}";
    }

    // TODO: desarrollar nuevas funcionalidades
}
