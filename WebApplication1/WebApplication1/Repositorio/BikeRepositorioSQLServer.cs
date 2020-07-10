using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Compare_bikes.Data;
using Compare_bikes.Modelos;

namespace Compare_bikes.Repositorio
{
    public class BikeRepositorioSQLServer : IBikeRepositorio
    {
        private ApplicationDbContext _contexto;
        public BikeRepositorioSQLServer(ApplicationDbContext contexto)
        {
            _contexto = contexto;
        }

        public List<Bike> GetBikes()
        {
            return _contexto.Bike.ToList();
        }
        public Bike GetBike(string id)
        {
            return _contexto.Bike.Where(s => s.Id.ToString().Equals(id)).FirstOrDefault();
        }

        public void CreateBike(Bike bike)
        {
            this._contexto.Bike.Add(bike);
            this._contexto.Entry(bike).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            this._contexto.SaveChanges();
        }

        public void DeleteBike(string id)
        {
            Bike bike = GetBike(id);
            this._contexto.Entry(bike).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
            this._contexto.SaveChanges();
        }

        public void UpdateBike(Bike bike)
        {
            _contexto.Bike.Add(bike);
            _contexto.Entry(bike).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _contexto.SaveChanges();
        }

    }
}
