﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatraSports.BL
{
    public class ReporteVentasPorProducto
    {
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        public static implicit operator ReporteVentasPorProducto(ReportedeVentasPorProductoBL v)
        {
            throw new NotImplementedException();
        }
    }
}
