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

    public void AddtoProducts(IDbConnection db)
    {
        var sql2 = "INSERT INTO products (pname) VALUES (@pname)";

        var p2 = new Products() { pname= "Call of Duty"};

        var rowsAffected = db.Execute(sql2, p2);
    }
        
}
    