using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Jordy_P2_AP2.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }
        public string Nombres { get; set; }

        [ForeignKey("ClienteId")]
        public virtual List<Ventas> venta { get; set; }
    }
}
