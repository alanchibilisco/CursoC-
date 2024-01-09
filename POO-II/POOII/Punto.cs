namespace POOII;

class Punto
{
    #region Constructor
    public Punto(int x, int y)
    {
        this.x = x;
        this.y = y;
        contadorDeObjetos++;
    }

    public Punto()
    {
        x = 0;
        y = 0;
        contadorDeObjetos++;
    }
    #endregion

    #region Propiedades
    private int x, y;
    private static int contadorDeObjetos=0;
    #endregion

    #region Metodos
    public double DistanciaHasta(Punto point)
    {
        int xDif=this.x - point.x;
        int yDif=this.y - point.y;

        double distancia=Math.Sqrt(Math.Pow(xDif,2)+Math.Pow(yDif,2));
        return distancia;
    }

    public static int GetContadorDeObjetos() => contadorDeObjetos;
    #endregion

    // TODO: crear propiedades y metodos correspondientes a la clase punto
}
