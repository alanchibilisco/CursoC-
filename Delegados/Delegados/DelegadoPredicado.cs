namespace Delegados;
//LOS PREDICADOS SON DELEGADOS QUE RETORNAN TRUE O FALSE, SON MUY UTILIZADOS PARA FILTRAR LISTAS DE VALORES COMPROBANDO SI UNA CONDICION ES CIERTA PARA UN VALOR DADO
/*
SINTAXIS Predicate<T> <NOMBRE>=new Predicate<T>(funcionDelegada);
*/
public class DelegadoPredicado
{

    public DelegadoPredicado() { }
    private static bool EsPar(int num)
    {
        if (num % 2 == 0) return true;
        else return false;
    }

    private static bool ExistePersona(Persona people){
        if (people.Nombre=="Juan")
        {
            return true;
        }else{
            return false;
        }
    }

    private static bool MayorEdad(Persona people){
        if (people.Edad>=18)
        {
            return true;
        }else{
            return false;
        }
    }

    Predicate<int> Predicado=new Predicate<int>(EsPar);

    Predicate<Persona> predicadoPersona=new Predicate<Persona>(ExistePersona);

    Predicate<Persona> predPersMayor=new Predicate<Persona>(MayorEdad);

    public void GetPar(List<int> list){
        var result=list.Find(Predicado);

        System.Console.WriteLine("El resultado es--> {0}",result);
    }

    public void GetPares(List<int> list){
        List<int> result=list.FindAll(Predicado);
        foreach (var value in result)
        {
            System.Console.WriteLine("Valor par--> {0}",value);
        }
    }
    public void GetPeople(List<Persona> list)
    {
        var result=list.Find(predicadoPersona);

        System.Console.WriteLine("Resultado --> {0}",result.Nombre);
    }

    public void MayorEdad(List<Persona> list){
        List<Persona> result=list.FindAll(predPersMayor);

        foreach (Persona value in result)
        {
            System.Console.WriteLine("Mayo de edad: {0}, {1}", value.Nombre, value.Edad);
        }
    }


}

