using Compare_bikes.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_bikes.Models
{
    public class BikeViewModel : Bike
    {
        [Required]
        [Display(Name = "Fabricante")]
        public string CodigoFabricante { get; set; }

        internal void SetBikeViewModel(Bike bike)
        {
            this.Id = bike.Id;
            this.Modelo = bike.Modelo;
            this.Descricao = bike.Descricao;
            this.Quadro = bike.Quadro;
            this.Suspencao = bike.Suspencao;
            this.Caixa_direcao = bike.Caixa_direcao;
            this.Fabricante = bike.Fabricante;
            this.CodigoFabricante = bike.Fabricante.Id.ToString();
        }
    }
}
