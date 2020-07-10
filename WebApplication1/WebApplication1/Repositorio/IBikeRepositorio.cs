using Compare_bikes.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_bikes.Repositorio
{
    public interface IBikeRepositorio
    {
        List<Bike> GetBikes();
        void CreateBike(Bike bike);
        Bike GetBike(string id);
        void UpdateBike(Bike bike);
        void DeleteBike(string id);
    }
}
