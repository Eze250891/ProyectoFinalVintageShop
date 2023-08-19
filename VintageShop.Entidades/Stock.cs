using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintageShop.Entidades
{
    public class Stock
    {
        public int Id { get; set; }
        public int IdZapato { get; set; }
        public int IdTalle { get; set; }
        public int Cantidad { get; set; }

        public virtual Zapato Zapato { get; set; }
        public virtual Talle Talle { get; set; }
    }
}
