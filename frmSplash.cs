namespace calculadora
{
    public partial class frmSplash : Form
    {
        List<string> loading = new List<string>() { "Loading.", "Loading..", "Loading..." };
        int teste = 0;
        public frmSplash()
        {
            InitializeComponent();
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {

        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            if (carregamentoFalso.Value < 100)
            {
                carregamentoFalso.Value = carregamentoFalso.Value + 10;
            }
            if (carregamentoFalso.Value == 10)
            {
                frmCalculadora frmTeste = new frmCalculadora();
                frmTeste.Show();
                tmrLoading.Stop();
                this.Hide();
            }
        }

        private void carregamentoFalso_Click(object sender, EventArgs e)
        {

        }

        private void tmrEfeito_Tick(object sender, EventArgs e)
        {

            lblLoading.Text = loading[teste];
            teste++;
            if (teste > 2)
            {
                teste = 0;
            }
        }
    }
}
