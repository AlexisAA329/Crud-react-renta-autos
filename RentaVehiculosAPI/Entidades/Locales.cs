﻿using RentaVehiculosAPI.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RentaVehiculosAPI.Entidades
{
    public class Locales
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(maximumLength: 50)]
        public string Telefono { get; set; }
        [PrimeraLetraMayuscula]
        public string Nombre { get; set; }
        public string Direccion { get; set; }

        

    }
}
