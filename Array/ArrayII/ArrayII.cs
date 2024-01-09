// See https://aka.ms/new-console-template for more information
namespace Array.II
{
    public class App
    {

        public static void Main(string[]args){
            
        }
        private string name;

        public App(string name)
        {
            this.name=name;
        }
        public string HelloWorld()
        {
            return $"Hello World ArrayII--> {this.name}";
        }
    }
}