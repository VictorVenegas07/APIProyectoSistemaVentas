﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVenta.DTO
{
    public class CategoriaDTO
    {
        [Key]
        public int IdCategoria { get; set; }

        public string? Nombre { get; set; }
    }
}
