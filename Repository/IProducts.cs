using CrudCreateDummy1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCreateDummy1.Repository
{
   public interface IProducts
    {
        Products PostProducts(Products pro);
        List<Products> GetProducts();

        Products UpdateProduct(Products pro);

       Products GetProductById(int id);

        Products DeleteProducts(int id);
    }
}
