using CrudCreateDummy1.Models;
using CrudCreateDummy1.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudCreateDummy1.Controllers
{
    public class ProductsController : Controller
    {
        private IProducts IPro;
        public ProductsController(IProducts _IPro)
        {
            IPro = _IPro;
        }
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult Show()
        {
            var objPro = IPro.GetProducts();
            return View(objPro);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Products pro)
        {
            IPro.PostProducts(pro);
            return RedirectToAction("Show");
        }

        public IActionResult Update(int id)
        {
            
            return View(IPro.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Update(Products pro)
        {
            IPro.UpdateProduct(pro);
            return RedirectToAction("Show");
            
        }

        public IActionResult Delete(int id)
        {
            IPro.DeleteProducts(id);
            return RedirectToAction("Show");
        }
    }
}
