using Demo2.Models;
using Demo2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo2.Services
{
    public class ProductService
    {

        private readonly ProductRepository _repo = new ProductRepository();

        public IEnumerable<Product> GetAll() => _repo.GetAll();
        public void Add(Product product) => _repo.Add(product);

    }
}