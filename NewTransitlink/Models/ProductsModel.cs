using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewTransitlink.Models
{
    public class ProductsModel 
    {
  
        private List<Product> products;

        public List<Product> findAll()
        {
            return this.products;
        }

        public Product find(int id)
        {
            return this.products.Single(p => p.ProductID.Equals(id));
        }

        public ProductsModel()
        {
            this.products = new List<Product>()
            {
               
            };
        }

    }
}