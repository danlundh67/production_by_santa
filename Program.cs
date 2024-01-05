using System;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

class Program
{
    static void Main(string[] args)
    {
        

        var sql = "SELECT * FROM products";
        var prod = new List<Products>();
        string connectionString=Methods.Connect();

        using (IDbConnection db = new MySqlConnection(connectionString))
        {
            //Methods.AddtoProducts(db);
            Methods.DeleteProducts(db);

            var result = db.Query("SELECT * FROM products"); // Metoden Query kommer från Dapper
            foreach (var row in result)
            {
                
                Console.WriteLine(row.pname);
            }
            prod = db.Query<Products>(sql).ToList();
        

        
        }

        foreach(var a in prod)
        {
            Console.WriteLine($"{a.pid}  {a.pname}");
        }
    }
}