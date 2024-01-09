namespace Delegados;
/*
SON FUNCIONES ANONIMAS, SIRVEN PARA SIMPLIFICAR EL CODIGO, SE UTILIZAN EN LINQ Y PARA CREAR DELEGADOS SENCILLOS

SINTAXIS

PARAMETROS => EXPRESION/BLOQUE DE SENTENCIA
*/
public class Lambda
{
    //FUNCION PARA OBTENER EL CUADRADO DE UN NUMERO
    /*private static int Cuadrado(int num)
    {
        return num * num;
    }*/

    private delegate int OpCuadrado(int num);

    //OpMatematica operacion = new OpMatematica(Cuadrado);

    //forma en escritura lambda simplifica crear la funcion delegada;
    OpCuadrado opCuadrado=new OpCuadrado(num=>num*num);

    private delegate int OpSuma(int num1, int num2);

    OpSuma opSuma=new OpSuma((num1, num2)=> num1+num2);


    private delegate void OpMsg(string msg);

    OpMsg opMessage=new OpMsg(msg=>{
        System.Console.WriteLine("Este es el mensage {0}", msg);
    });


    public void GetCuadrado(int num){
        int result=opCuadrado(num);
        System.Console.WriteLine("El resultado de elevar al cuadrado {0}, es: {1}", num, result);
    }


    public void GetSuma(int num1, int num2){
        int result=opSuma(num1, num2);
        System.Console.WriteLine("El resultado de sumar {0} mas {1}, es: {2}", num1, num2, result);
    }

    public void SetMessage(string msg){
        opMessage(msg);
    }

}
