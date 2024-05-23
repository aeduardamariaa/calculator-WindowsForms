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
            }
            tbResult.Text = Convert.ToString(Resultado);
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            Resultado = 0;
            tbResult.Clear();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
