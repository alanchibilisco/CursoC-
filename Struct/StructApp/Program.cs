namespace StructApp
{
    class App
    {
        public static void Main(string[]args)
        {
            Empleado empleado=new Empleado(3500, 250);
            empleado.cambioSalario(empleado, 250);
            System.Console.WriteLine(empleado);


            StructEmployee employee= new StructEmployee(3500, 250);

            employee.cambioSalario(employee, 250);

            System.Console.WriteLine(employee);
            /*
            EN ESTE EJEMPLO SE VEN LAS DIFERENCIA ENTRE CLASES Y STRUCT, MIENTRAS QUE EN LA CLASE SE LA INSTANCIA Y LUEGO SE MODIFICAN LOS VALORES DE CAMPOS Y SE VEN REFLEJADOS EN EL C.WRITE, EN EL CASO DE LA STRUCT TAMBIEN SE LA INSTANCIA Y SE LE MODIFICAN LOS VALORES DE LOS CAMPOS, PERO AL OBTENER LOS VALORES DE LOS CAMPOS ESTOS REFLEJAN QUE CONTINUAN SIENDO LOS MISMOS CON LOS QUE SE INSTANCIO
            */

            employee.Test(500);

            System.Console.WriteLine(employee.ToString());
        }
    }
}