using System;
using System.Data;
using MySql.Data.MySqlClient;
using Dapper;

public class Childs
{
    public int cid {get;set;}
    public string? name {get;set;}
    public int nice;
}

public class Products
{
    public int pid {get;set;}
    public string? pname {get;set;}
}

public class Whishlist
{
    public int wid {get;set;}
    public int childid {get;set;}
    public int prodid {get;set;}
    public int priority {get;set;}

}