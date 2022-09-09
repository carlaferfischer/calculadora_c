namespace calculadora_2
{
    public partial class Form1 : Form
    {
        decimal calculo;
        bool adicao = false;
        bool subtracao = false;
        bool multiplicacao = false;
        bool divisao = false;
        bool resultado = false;
        bool porcento = false;
        bool quadrado = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "1";
            txtResultado.Text += "1";
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "2";
            txtResultado.Text += "2";
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "3";
            txtResultado.Text += "3";
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "4";
            txtResultado.Text += "4";
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "5";
            txtResultado.Text += "5";
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "6";
            txtResultado.Text += "6";
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "7";
            txtResultado.Text += "7";
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "8";
            txtResultado.Text += "8";
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "9";
            txtResultado.Text += "9";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "0";
            txtResultado.Text += "0";
        }

        private void btnVigula_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += ",";
            txtResultado.Text += ",";
        }

        private void btnAoQuadrado_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "²";
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            porcento = false;
            quadrado = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "+";
            txtResultado.Text = "";

            adicao = true;
            subtracao = false;
            multiplicacao = false;
            divisao = false;
            porcento = false;
            quadrado = false;

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "-";
            txtResultado.Text = "";

            adicao = false;
            subtracao = true;
            multiplicacao = false;
            divisao = false;
            porcento = false;
            quadrado = false;
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "x";
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = true;
            divisao = false;
            porcento = false;
            quadrado = false;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            calculo = Convert.ToDecimal(txtResultado.Text);

            txtOperacao.Text += "/";
            txtResultado.Text = "";

            adicao = false;
            subtracao = false;
            multiplicacao = false;
            divisao = true;
            porcento = false;
            quadrado = false;
        }

        private void btnPorcento_Click(object sender, EventArgs e)
        {
            txtOperacao.Text += "%";
            txtResultado.Text = "";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            resultado = true;
            txtOperacao.Text = "";

            if (adicao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) + calculo);
                txtOperacao.Text += txtResultado.Text;
            }

            if (subtracao == true)
            {
                txtResultado.Text = Convert.ToString(calculo - Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }

            if (multiplicacao == true)
            {
                txtResultado.Text = Convert.ToString(Convert.ToDecimal(txtResultado.Text) * calculo);
                txtOperacao.Text += txtResultado.Text;
            }

            if (divisao == true)
            {
                txtResultado.Text = Convert.ToString(calculo / Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }

            if (porcento == true)
            {
                txtResultado.Text = Convert.ToString(calculo/100 * Convert.ToDecimal(txtResultado.Text));
                txtOperacao.Text += txtResultado.Text;
            }

            if (quadrado == true)
            {
                txtResultado.Text = Convert.ToString(calculo * calculo);
                txtOperacao.Text += txtResultado.Text;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            txtOperacao.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            try
            {
                string Apagar = txtResultado.Text;

                Apagar = Apagar.Remove(Apagar.Length - 1);

                txtResultado.Text = Apagar;
                txtOperacao.Text = Apagar;
            }
            catch (Exception)
            {

            }
        }
    }
}