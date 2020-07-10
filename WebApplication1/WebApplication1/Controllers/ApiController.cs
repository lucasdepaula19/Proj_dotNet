using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compare_bikes.Modelos;
using Compare_bikes.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AulaFullStack.Controllers
{
    public class ApiController : Controller
    {
        private IFabricanteRepositorio _fabricanteRepositorio;
        public ApiController(IFabricanteRepositorio fabricanteRepositorio)
        {
            _fabricanteRepositorio = fabricanteRepositorio;
        }

        public Fabricante GetFabricante(string id)
        {
            return _fabricanteRepositorio.GetFabricante(id);
        }
    }
}