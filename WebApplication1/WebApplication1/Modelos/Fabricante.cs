using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Compare_bikes.Modelos
{
    public class Fabricante
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [StringLength(250)]
        [Required(ErrorMessage = "Informe um nome")]
        public String Nome { get; set; }
    }
}
