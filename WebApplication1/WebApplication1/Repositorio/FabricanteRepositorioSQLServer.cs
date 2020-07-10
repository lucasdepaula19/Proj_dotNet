using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compare_bikes.Data;
using Compare_bikes.Modelos;

namespace Compare_bikes.Repositorio
{
    public class FabricanteRepositorioSQLServer : IFabricanteRepositorio
    {
        private ApplicationDbContext _contexto;
        public FabricanteRepositorioSQLServer(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public List<Fabricante> GetFabricantes()
        {
            return _contexto.Fabricante.ToList();
        }

        public Fabricante GetFabricante(string id)
        {
            return _contexto.Fabricante.Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }

        public void CreateFabricante(Fabricante fabricante)
        {
            this._contexto.Fabricante.Add(fabricante);
            this._contexto.Entry(fabricante).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this._contexto.SaveChanges();
        }

        public void DeleteFabricante(string id)
        {
            Fabricante fabricante = GetFabricante(id);
            this._contexto.Entry(fabricante).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this._contexto.SaveChanges();
        }

        public void UpdateFabricante(Fabricante fabricante)
        {
            _contexto.Fabricante.Add(fabricante);
            _contexto.Entry(fabricante).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }

    }
}
