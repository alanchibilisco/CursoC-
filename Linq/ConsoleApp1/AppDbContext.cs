using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using MySql.Data.MySqlClient;

namespace ConsoleApp1;

public class AppDbContext:DbContext
{
    public DbSet<EmpresaDB> Empresas{get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        string connectionString="Server=127.0.0.1;Port=3306;Database=c_sharp;User ID=alan;Password=alan;SSL Mode=None;";
        MySqlConnection connection=new MySqlConnection(connectionString);
        optionsBuilder.UseMySQL(connection);

    }


}
