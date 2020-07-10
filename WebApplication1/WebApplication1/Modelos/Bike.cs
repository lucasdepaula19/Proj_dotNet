using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_bikes.Modelos
{
    public class Bike
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage ="Informe o modelo")]
        public String Modelo {get; set;}

        //[StringLength(250)]
        [Required(ErrorMessage = "Informe o fabricante")]
        public Fabricante Fabricante { get; set; }

        [StringLength(4000)]
        [Required(ErrorMessage = "Informe uma descrição")]
        public String Descricao { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Informe o quadro")]
        public String Quadro { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Informe a suspenção")]
        public String Suspencao { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Informe a Caixa de direção")]
        public String Caixa_direcao { get; set; }


    }
}
