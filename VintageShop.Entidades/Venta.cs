using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintageShop.Entidades
{
    public class Venta
    {
        public int id {  get; set; }
        public DateTime FechaDeVenta { get; set; }
        public Usuario Usuario { get; set; }
    }
}
