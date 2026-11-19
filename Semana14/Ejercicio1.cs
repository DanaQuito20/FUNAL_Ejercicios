namespace s14
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text), n2 = int.Parse(txtNum2.Text), suma;
            suma = n1 + n2;
            txtResultado.Text = suma.ToString();
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text), n2 = int.Parse(txtNum2.Text), resta;
            resta = n1 - n2;
            txtResultado.Text = resta.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text), n2 = int.Parse(txtNum2.Text), multiplicacion;
            multiplicacion = n1 * n2;
            txtResultado.Text = multiplicacion.ToString();
        }

        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            double n1 = double.Parse(txtNum1.Text), n2 = double.Parse(txtNum2.Text), division;
            division = n1 / n2;
            txtResultado.Text = division.ToString();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text), n2 = int.Parse(txtNum2.Text);
            if (n1 > n2) txtResultado.Text = n1.ToString();
            else txtResultado.Text = n2.ToString();
        }

        private void btnMenor_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text), n2 = int.Parse(txtNum2.Text);
            if (n1 < n2) txtResultado.Text = n1.ToString();
            else txtResultado.Text = n2.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
