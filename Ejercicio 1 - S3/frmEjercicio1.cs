using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1___S3
{
    public partial class frmEjercicio1 : Form
    {
        public frmEjercicio1()
        {
            InitializeComponent();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            //Declaramos variables
            double montoRetiro, saldoDispo;
            string condicion;

            //Ingresamos sus valores a las variables
            montoRetiro = Convert.ToDouble(txtMontoRetiro.Text);
            saldoDispo = Convert.ToDouble(txtSaldoDisponible.Text);
            condicion = "Fondos suficientes para realizar esta operación";

            //Evaluamos la ECS
            if (montoRetiro > saldoDispo) condicion = "Fondos insuficientes para realizar esta operación";

            //Mostramos la condición
            txtCondicion.Text = condicion;

            //Mostramos el botón Limpiar
            btnLimpiar.Visible = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMontoRetiro.Text = "";
            txtSaldoDisponible.Text = "";
            txtCondicion.Text = "";
            btnLimpiar.Visible = false;
        }
    }
}