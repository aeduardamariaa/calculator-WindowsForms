namespace projetao
{
    public partial class Form1 : Form
    {
        private string OperacaoSelecionada { get; set; }
        private decimal Resultado { get; set; }
        private decimal Valor { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void btDigit_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            tbResult.Text += button.Text;

        }
        private void btOperation_Click(object sender, EventArgs e)
        {
            var operation = (Button)sender;
            Valor = Convert.ToDecimal(tbResult.Text);
            tbResult.Text += operation.Text;
            OperacaoSelecionada = operation.Text;
            tbResult.Text = "";
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case "+":
                    Resultado = Valor + Convert.ToDecimal(tbResult.Text);
                    break;
                case "-":
                    Resultado = Valor - Convert.ToDecimal(tbResult.Text);

                    break;
                case "*":
                    Resultado = Valor * Convert.ToDecimal(tbResult.Text);

                    break;
                case "/":
                    Resultado = Valor / Convert.ToDecimal(tbResult.Text);
                    break;

                case "x^1/2":
                    Resultado = (decimal) Math.Sqrt(
                        Convert.ToDouble(Valor)
                        );
                    break;

                case "^":
                    Resultado = (decimal) Math.Pow(Convert.ToDouble(Valor), Convert.ToDouble(tbResult.Text));
                    break;

                case "%":
                    Resultado = Valor * (Convert.ToDecimal(tbResult.Text)/100);
                    break;
            }
            tbResult.Text = Convert.ToString(Resultado);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Resultado = 0;
            tbResult.Clear();
        }
    }
}
