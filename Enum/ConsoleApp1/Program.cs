namespace ConsoleApp1
{
    class ConsoleApp1
    {
        public static void Main(string[]args)
        {
            System.Console.WriteLine(EEstaciones.PRIMAVERA);

            EEstaciones alergia=EEstaciones.PRIMAVERA;

            System.Console.WriteLine(alergia);

            EBonus bonus=EBonus.bajo;
            //para mostrar el valor de la prop del enum hay q hacer un casting;

            double bonusD = (double)bonus; 
            string bonusStr=bonus.ToString();
            System.Console.WriteLine(bonusD);
            System.Console.WriteLine(bonusStr);

            Empleado empl=new Empleado(2559.65, (double)EBonus.extra);

            System.Console.WriteLine(empl.ToString());
        }
    }
}
