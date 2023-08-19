using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintageShop.Entidades
{
    public class Talle
    {
        public int Id { get; set; }
        public int IdZapato { get; set; }
        public int TalleNumero { get; set; }

        public virtual Zapato Zapato { get; set; }
        public virtual List<Stock> StockList { get; set; } = new List<Stock>();


    }
}
