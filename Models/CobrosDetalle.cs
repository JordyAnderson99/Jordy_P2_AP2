using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Jordy_P2_AP2.Models
{
    public class CobrosDetalle
    {
        [Key]
        public int Id { get; set; }
        public int CobroId { get; set; }
        public Cobros Cobro { get; set; }
        public int VentaId { get; set; }
        public Ventas Venta { get; set; }
        public double Cobrado { get; set; }
    }
}
