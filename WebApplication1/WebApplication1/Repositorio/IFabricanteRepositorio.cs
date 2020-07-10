using Compare_bikes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_bikes.Repositorio
{
    public interface IFabricanteRepositorio
    {
        List<Fabricante> GetFabricantes();
        void CreateFabricante(Fabricante fabricante);
        Fabricante GetFabricante(string id);
        void UpdateFabricante(Fabricante fabricante);
        void DeleteFabricante(string id);
    }
}
