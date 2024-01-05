using System;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

public class Methods
{
    static public string Connect()
    {
        string connectionString = "server=127.0.0.1;User ID=root;database=santaprod"; // IDBConnection kommer från System.Data. MySqlConnection kommer från MySql.Data.MySqlClient
        return connectionString;
    }

    static public void AddtoProducts(IDbConnection db)
    {
        var sql2 = "INSERT INTO products (pname) VALUES (@pname)";
        Console.WriteLine("State the product:");
        string tmp = Console.ReadLine()+"";

        var p2 = new Products() { pname= tmp};

        var rowsAffected = db.Execute(sql2, p2);
    }

    static public void DeleteProducts(IDbConnection db)
    {
        
        Console.WriteLine("State the product id:");
        int tmp = int.Parse(Console.ReadLine()+"");
        var sql2 = "DELETE FROM products WHERE pid="+tmp;
        //var p2 = new Products() { pid = tmp};

        var rowsAffected = db.Execute(sql2);
    }
        
}
    