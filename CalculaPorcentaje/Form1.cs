using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculaPorcentaje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string label1 = txtPrecio.Text;
            int Precio = Int32.Parse(label1);

            string label2 = txtDescuento.Text;
            int Descuento = Int32.Parse(label2);

            int Total = Precio * Descuento / 100;

            int Final = (Precio - Total);

            MessageBox.Show("El precio es de : " + Final);

        }
    }
}
