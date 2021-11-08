using CatraSports.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatraSports.Win
{
    

    public partial class Form2 : Form
    {
        private object listadeVentasPorProductoBindingSource;
        ReportedeVentasPorProductoBL _reportedeVentasPorProductoBL;

        public Form2()
        {
            InitializeComponent();
            _reportedeVentasPorProductoBL = new ReportedeVentasPorProductoBL();
            RefrescarDatos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }
        private void RefrescarDatos()
        {
            var listadeVentasPorProducto = _reportedeVentasPorProductoBL.ObtenerVentasPorProducto();
            listadeVentasPorProductoBindingSource.DataSource = listadeVentasPorProducto;
            listadeVentasPorProductoBindingSource.ResetBinding (false);
           
        }
    }
}
