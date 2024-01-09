namespace Genericos;

public class Estudiante
{
    public Estudiante(string materia)
    {
        this.materia=materia;
    }

    public string GetMateria()
    {
        return this.materia;
    }
    private string materia;
}
