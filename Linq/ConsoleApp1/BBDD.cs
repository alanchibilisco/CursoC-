using System.Data;
using System.Runtime.CompilerServices;
using MySql.Data.EntityFrameworkCore.Extensions;
using MySql.Data.MySqlClient;

namespace ConsoleApp1;

public class BBDD
{
    private string database = "Server=127.0.0.1;Port=3306;Database=c_sharp;User ID=alan;Password=alan;SSL Mode=None;";

    public void NewEmpresa(string nombre)
    {
        using (MySqlConnection connection = new MySqlConnection(database))
        {
            try
            {
                connection.Open();
                string query = @"INSERT INTO Empresa (nombre) VALUES (@nombre)";
                using MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                var rows = command.ExecuteNonQuery();
                System.Console.WriteLine("Rows affected--> {0}", rows);
            }
            catch (System.Exception ex)
            {
                System.Console.WriteLine("Error--> {0}", ex);
                connection.Close();


            }
        }
    }

    public void NewCargo(string nombre)

    {
        using (MySqlConnection connection = new MySqlConnection(database))
        {
            try
            {
                connection.Open();
                string query = @"INSERT INTO Cargo (nombre_cargo) VALUES (@nombre)";
                using MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@nombre", nombre);
                int rows = command.ExecuteNonQuery();
                System.Console.WriteLine("Insertado --> {0}", rows);
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Error --> {0}", ex);
            }
        }
    }


    public void GetEmpresas()
    {
        using (MySqlConnection connection = new MySqlConnection(database))
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM Empresa";
                using MySqlCommand command = new MySqlCommand(query, connection);
                using MySqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    var result = reader.GetValue("nombre");
                    System.Console.WriteLine("Result--> {0}", result);
                    System.Console.WriteLine($"ID: {reader["id"]}, Nombre: {reader["nombre"]}");
                }
            }
            catch (System.Exception ex)
            {

                System.Console.WriteLine("Error--> {0}", ex);
            }
        }
    }
/*
using System;
using MySql.Data.MySqlClient;

class Program
{
    static void Main()
    {
        string connectionString = "Server=localhost;Database=NombreBaseDeDatos;User=root;Password=TuContraseña;";

        // Ejemplo de operaciones CRUD para la tabla Empresa
        // Insertar
        InsertarEmpresa(connectionString, "NombreEmpresa", "DireccionEmpresa");

        // Leer
        LeerEmpresas(connectionString);

        // Actualizar
        ActualizarEmpresa(connectionString, 1, "NuevoNombre", "NuevaDireccion");

        // Eliminar
        EliminarEmpresa(connectionString, 1);
    }

    static void InsertarEmpresa(string connectionString, string nombre, string direccion)
    {
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string query = $"INSERT INTO Empresa (Nombre, Direccion) VALUES ('{nombre}', '{direccion}')";

        using MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();

        Console.WriteLine("Empresa insertada correctamente.");
    }

    static void LeerEmpresas(string connectionString)
    {
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string query = "SELECT * FROM Empresa";

        using MySqlCommand command = new MySqlCommand(query, connection);
        using MySqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"ID: {reader["Id"]}, Nombre: {reader["Nombre"]}, Direccion: {reader["Direccion"]}");
        }
    }

    static void ActualizarEmpresa(string connectionString, int id, string nuevoNombre, string nuevaDireccion)
    {
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string query = $"UPDATE Empresa SET Nombre = '{nuevoNombre}', Direccion = '{nuevaDireccion}' WHERE Id = {id}";

        using MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();

        Console.WriteLine("Empresa actualizada correctamente.");
    }

    static void EliminarEmpresa(string connectionString, int id)
    {
        using MySqlConnection connection = new MySqlConnection(connectionString);
        connection.Open();

        string query = $"DELETE FROM Empresa WHERE Id = {id}";

        using MySqlCommand command = new MySqlCommand(query, connection);
        command.ExecuteNonQuery();

        Console.WriteLine("Empresa eliminada correctamente.");
    }
}
*/
    
}
