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
    public class BikeController : Controller
    {
        [HttpGet]
        public IActionResult List([FromServices] IBikeRepositorio bikeRepositorio)
        {
            //List<Bike> bikes = bikeRepositorio.GetBikes();
            return View(bikeRepositorio.GetBikes());
        }
        /*
                [HttpGet]
                public IActionResult Create()
                {
                    return View();
                }

                [HttpPost]
                public IActionResult Create(Bike bike, [FromServices] IBikeRepositorio bikeRepositorio)
                {
                    bikeRepositorio.CreateBike(bike);
                    return RedirectToAction("Index");
                }
        */
        [HttpGet]
        public IActionResult Create([FromServices] IFabricanteRepositorio repositorioFabricante)
        {
            ViewBag.Fabricantes = repositorioFabricante.GetFabricantes();
            return View();
        }

        [HttpPost]
        public IActionResult Create(BikeViewModel bike, [FromServices] IBikeRepositorio bikeRepositorio, [FromServices] IFabricanteRepositorio repositorioFabricante)
        {
            bike.Fabricante = repositorioFabricante.GetFabricante(bike.CodigoFabricante);
            bikeRepositorio.CreateBike(bike);
            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult Delete(string id, [FromServices] IBikeRepositorio bikeRepositorio)
        {
            bikeRepositorio.DeleteBike(id);
            return RedirectToAction("List");
        }

        [HttpGet]
        public IActionResult Details(string id, [FromServices] IBikeRepositorio bikeRepositorio)
        {
            Bike bike = bikeRepositorio.GetBike(id);
            return View(bike);
        }

        [HttpGet]
        public IActionResult Edit(string id, [FromServices] IBikeRepositorio bikeRepositorio, [FromServices] IFabricanteRepositorio repositorioFabricante)
        {
            //Bike bike = bikeRepositorio.GetBike(id);
            //return View(bike);
            ViewBag.Fabricantes = repositorioFabricante.GetFabricantes();
            Bike bike = bikeRepositorio.GetBike(id);
            BikeViewModel bikeView = new BikeViewModel();
            bikeView.SetBikeViewModel(bike);
            return View(bikeView);
        }

        [HttpPost]
        public IActionResult Edit(BikeViewModel bike, [FromServices] IBikeRepositorio bikeRepositorio, [FromServices] IFabricanteRepositorio repositorioFabricante)
        {
            //bikeRepositorio.UpdateBike(bike);
            //return RedirectToAction("List");

            bike.Fabricante = repositorioFabricante.GetFabricante(bike.CodigoFabricante);
            bikeRepositorio.UpdateBike(bike);
            return RedirectToAction("List");
        }

    }
}
