using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3___S3
{
    public partial class frmEjercicio3 : Form
    {
        public frmEjercicio3()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            int horas, horasExtra = 0, tarifaFija = 10, tarifaExtra = 0, tarifaTotal;

            horas = Convert.ToInt32(txtHorasEstacionado.Text);

            if (horas > 2)
            {
                horasExtra = horas - 2;
                tarifaExtra = horasExtra * 5;
                tarifaTotal = tarifaFija + tarifaExtra;
                label4.Visible = true;

            }
            else
            {
                tarifaTotal = tarifaFija;
                label4.Visible = false;
            }

            txtTotal.Text = "S/." + tarifaTotal.ToString();

            btnLimpiar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHorasEstacionado.Text = "";
            txtTotal.Text = "";
            btnLimpiar.Visible = false;
            label4.Visible = false;
        }
    }
}