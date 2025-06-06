﻿using Demo2.Models;
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

        //public IEnumerable<Product> GetAll() => _repo.GetAll();
        public IEnumerable<Product> GetAll()
        {
            var list = _repo.GetAll();
            return list ?? new List<Product>(); // 避免傳回 null
        }

        public void Add(Product product) => _repo.Add(product);
        public Product GetById(int id) => _repo.GetById(id);
        public void Update(Product product) => _repo.Update(product);
        public void Delete(int id) => _repo.Delete(id);
    }
}
