using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Compare_bikes.Data;
using Compare_bikes.Modelos;
using Compare_bikes.Models;
using Compare_bikes.Repositorio;

namespace Compare_bikes.Controllers
{
    public class FabricanteController : Controller
    {
        [HttpGet]
        public IActionResult List([FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            /*FabricanteIndexViewModel model = new FabricanteIndexViewModel();
            model.Fabricantes = fabricanteRepositorio.GetFabricantes();
            return View(model);
            */

            List<Fabricante> Fabricantes = fabricanteRepositorio.GetFabricantes();
            return View(Fabricantes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Fabricante fabricante, [FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            fabricanteRepositorio.CreateFabricante(fabricante);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Delete(string id, [FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            fabricanteRepositorio.DeleteFabricante(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(string id, [FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            Fabricante fabricante = fabricanteRepositorio.GetFabricante(id);
            return View(fabricante);
        }

        [HttpGet]
        public IActionResult Edit(string id, [FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            Fabricante fabricante = fabricanteRepositorio.GetFabricante(id);
            return View(fabricante);
        }

        [HttpPost]
        public IActionResult Edit(Fabricante fabricante, [FromServices] IFabricanteRepositorio fabricanteRepositorio)
        {
            fabricanteRepositorio.UpdateFabricante(fabricante);
            return RedirectToAction("List");
        }

    }
}
