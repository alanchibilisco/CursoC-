

namespace Herencia
{
    class App
    {
        public static void Main(string[] args)
        {

            Humano humano = new Humano("Humano");

            Gorila gorila = new Gorila("Gorila");

            Caballo caballo = new Caballo("Caballo");

            /*caballo.GetNombreSerVivo();
            humano.GetNombreSerVivo();
            gorila.GetNombreSerVivo();*/
            caballo.getNombre();
            humano.getNombre();
            gorila.getNombre();

            //principio de sustitucion, se puede por que caballo hereda de Mamifero, pero se pierden los metodos de caballo
            Mamiferos animal = new Caballo("CabMamifero");

            Mamiferos[] arrMa = new Mamiferos[3];

            arrMa[0] = humano;
            arrMa[1] = gorila;
            arrMa[2] = caballo;

            //arrMa[0].GetNombreSerVivo();
            arrMa[0].getNombre();

            //herencia de metodos: new, virtual, override, parte del polimorfismo, el metodo pensar efectua la accion en funcion del tipo del obj
            humano.Pensar();
            gorila.Pensar();
            caballo.Pensar();

            Reptil reptil = new Reptil("Reptil");

            reptil.getNombre();
        }
    }

    //clase abstracta, es aquella en la que al menos uno de sus metodos esta definido como abstracto, esto obliga a las clases que hereden de ella a que implementen los metodos abstractos definidos en ella, tal cual lo hacen las interfaces, una clase abstracta pura es aquella en la cual todos sus metodos son abstractos, es igual a una interfaz
    abstract class Animales
    {
        public void Respirar()
        {
            System.Console.WriteLine("Soy capaz de respirar");
        }

        public abstract void getNombre();

    }

    //CLASES SELLADAS SON AQUELLAS DE LAS QUE NO SE PUEDE HEREDAR, LOS METODOS SELLADOS LO QUE PERMITE ES QUE NO SE PUEDAN SOBREESCRIBIR, se utiliza la palabra sealed

    class Reptil : Animales
    {
        private string nombreSerVivo;

        public Reptil(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }

        public override void getNombre()
        {
            System.Console.WriteLine($"El nombre del reptil es: {this.nombreSerVivo}");
        }
    }

    class Mamiferos : Animales
    {

        private string nombreSerVivo;

        public Mamiferos(string nombreSerVivo)
        {
            this.nombreSerVivo = nombreSerVivo;
        }
        // protected void Respirar(){
        //     System.Console.WriteLine("Soy capaz de respirar");
        // }

        public void CuidarCrias()
        {
            System.Console.WriteLine("Cuido de las crias");
        }

        public void GetNombreSerVivo()
        {
            System.Console.WriteLine($"El nombre del mamifero es: {this.nombreSerVivo}");
        }

        //para definir que las clases hijas pueden cambiar el comportamiento del metodo heredado definirlo como virtual
        public virtual void Pensar()
        {
            System.Console.WriteLine("Pensamiento basico e instintivo");
        }

        public override void getNombre()
        {
            System.Console.WriteLine($"El nombre del mamifero es: {this.nombreSerVivo}");
        }
    }

    class Caballo : Mamiferos
    {
        // el :base() llama al constructor de la clase padre
        public Caballo(string nombreSerVivo) : base(nombreSerVivo)
        {

        }
        public void Galopar()
        {
            System.Console.WriteLine("Soy capaz de galopar");
            base.Respirar();
        }


    }

    class Humano : Mamiferos
    {

        public Humano(string nombreSerVivo) : base(nombreSerVivo)
        {

        }

        //con esto sobreescribimos el metodo heredado para ocultarlo utilizamos el new o el override si y solo si el metodo heredado esta definido como virtual, con el sealed declaramos que cualquier clase que herede de Humano no pueda sobreescribir el metodo Pensar()
        sealed public override void Pensar()
        {
            System.Console.WriteLine("Soy capaz de pensar");
        }

    }

    class Adolescente : Humano
    {
        public Adolescente(string nombreSerVivo) : base(nombreSerVivo) { }
        public new void Pensar(){

        }

    }
    sealed class Gorila : Mamiferos
    {

        public Gorila(string nombreSerVivo) : base(nombreSerVivo)
        {

        }
        public void Trepar()
        {
            System.Console.WriteLine("Soy capaz de trepar");
        }


        override public void Pensar()
        {
            System.Console.WriteLine("Pensamiento instintivo avanzado");
        }

    }

    /*ESTO GENERA UN ERROR DE COMPILACION POR QUE NO SE PUEDE HEREDAR DE LA CLASE GORILA DADO Q ES SELLADA
    class Chimpance:Gorila{
        public Chimpance(string nombreSerVivo):base(nombreSerVivo){

        }

    }*/
}
