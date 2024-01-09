// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");




namespace SecondApp
{
    class App{

        // variables con ambito de clases

        int number1=5;
        int numbre2=7;

        static void Main(string[]args){
            
            Message();

            System.Console.WriteLine($"El resultado de Sum es--> {Sum(7,5)}");

            System.Console.WriteLine(Texto("Hello metodo"));

            System.Console.WriteLine(Metodo("Hello"));

            System.Console.WriteLine(Message2("Alan","Chibilisco"));
        }

       

        //para declarar y poder llamar un metodo fuera del main hay q hacerlo static
        static void Message(){
            System.Console.WriteLine("Hello world");
        }

        static int Sum(int num1, int num2){
            return (num1+num2);
        }

        // si el metodo solo posee una linea de codigo se puede declarar de la siguiente manera
        static string Texto(string str)=>str;

        //SOBRECARGA, la sobrecarga funciona con el mismo nombre del metodo y con distintos tipos y cantidades de parametros, funciona tambien con el tipo de dato devuelto;

        static void Metodo(){
                        
        }

         static string Metodo(string str){
            return str;
        }

        static int Metodo(int number){
            return number;
        }

        //PARAMTEROS OPCIONALES, definir el parametro con un valor ya asignado

        static string Message2(string str1, string str2, string str3=""){
            return $"{str1} {str2} {str3}";
        }
    }
}
