using Dapper;
using Demo2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Demo2.Repositories
{
    public class ProductRepository
    {

        private readonly string _connStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public IEnumerable<Product> GetAll() =>
            new SqlConnection(_connStr).Query<Product>("SELECT * FROM Produs");
        public void Add(Product product) =>
            new SqlConnection(_connStr).Execute("INSERT INTO Produs (Name, Price) VALUES (@Name, @Price)", product);
        public Product GetById(int id) =>
            new SqlConnection(_connStr).QueryFirstOrDefault<Product>("SELECT * FROM Produs WHERE Id = @Id", new { Id = id });
        public void Update(Product product) =>
            new SqlConnection(_connStr).Execute("UPDATE Produs SET Name = @Name, Price = @Price WHERE Id = @Id", product);
        public void Delete(int id) =>
          new SqlConnection(_connStr).Execute("DELETE FROM Produs WHERE Id = @Id", new { Id = id });
    }
}