﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VintageShop.Entidades
{
    public class Pago
    {
        public int Id { get; set; }
        public int IdFormaDePago { get; set; }

        public int IdPrecioZapato { get; set; }

        public virtual FormaDePago FormaDePagoUtilizada { get; set; }
        public virtual Zapato ZapatoSeleccionado { get; set; }




    }
}
