using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2___S3
{
    public partial class frmEjercicio2 : Form
    {
        public frmEjercicio2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temperatura;
            string condicion;

            temperatura = Convert.ToInt32(txtTemperatura.Text);
            condicion = "Temperatura estable";

            if (temperatura > 30)
            {
                condicion = "Alerta: Enfriamiento activado por alta temperatura";
                btnEnfriar.Visible = true;
            }

            txtResultados.Text = condicion;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtTemperatura.Text = "";
            txtResultados.Text = "";
            btnEnfriar.Visible = false;
        }
    }
}
