using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Jordy_P2_AP2.Models
{
    public class Ventas
    {
        [Key]
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public virtual Clientes Cliente { get; set; }
        public double Monto { get; set; }
        public double Balance { get; set; }

        [ForeignKey("VentaId")]
        public virtual List<CobrosDetalle> Detalle { get; set; } = new List<CobrosDetalle>();
    }
}
