using MySql.Data.MySqlClient;

namespace ConsoleApp1;

public class BBDD
{
    private string database="Server=127.0.0.1;Port=3306;Database=c_sharp;User ID=alan;Password=alan;SSL Mode=None;";

    public void NewEmpresa(string nombre)
    {
        using(MySqlConnection connection=new MySqlConnection(database)){
            try
            {
                connection.Open();
                string query=$"INSERT INTO Empresa (nombre) VALUE ('{nombre}')";
                using MySqlCommand command=new MySqlCommand(query, connection);
                var rows=command.ExecuteNonQuery();
                System.Console.WriteLine("Rows affected--> {0}", rows);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Error--> {0}", ex);
                connection.Close();

                
            }
        }
    }
}
