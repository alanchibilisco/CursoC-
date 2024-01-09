using ClassLibrary1;
using Array.II;
namespace Array
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] edades = new int[4];
            // int[] arr= {2,3,4,5,6};

            //array implicito sin tipo de datos y sin longitug
            var arrImplicito = new[] { 12, 13, 14, 15 };

            //array objetos
            Empleados[] arrEmpleados = new Empleados[2];

            arrEmpleados[0] = new Empleados("Sara", 37);

            Empleados Ana = new Empleados("Ana", 27);

            arrEmpleados[1] = Ana;

            //array anonimos

            var arrAnonimos = new[]{
                new{name="Juan",age=19},
                new{name="Leo",age=49}
            };


            for (int i = 0; i < arrAnonimos.Length; i++)
            {
                System.Console.WriteLine($"{arrAnonimos[i].name} - {arrAnonimos[i].age}");
            }

           Class1 test=new Class1("Alan");

           System.Console.WriteLine(test.HelloWorld());
                    
            //TODO: hacer algo nuevo

            App t=new App("Tomy");

            System.Console.WriteLine(t.HelloWorld());
        }
    }

    class Empleados
    {
        public Empleados(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        public int age;

    }
}
