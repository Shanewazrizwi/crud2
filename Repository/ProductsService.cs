using CrudCreateDummy1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCreateDummy1.Repository
{
    public class ProductsService:IProducts
    {
        private ApplicationContext Context;
        public ProductsService(ApplicationContext _Context)
        {
            Context = _Context;
        }

        public Products DeleteProducts(int id)
        {
           var objPro= Context.products.SingleOrDefault(e => e.Id == id);
            Context.products.Remove(objPro);
            Context.SaveChanges();
            return objPro;
        }

        public Products GetProductById(int id)
        {
           var objPro= Context.products.SingleOrDefault(e => e.Id == id);
            return objPro;
        }

        public List<Products> GetProducts()
        {
           var objPro= Context.products.ToList();
            return objPro;
        }

        public Products PostProducts(Products pro)
        {
            Context.products.Add(pro);
            Context.SaveChanges();
            return pro;
        }

        public Products UpdateProduct(Products pro)
        {
            Context.products.Update(pro);
            Context.SaveChanges();

            return pro;
        }
    }
}
