namespace calculadora
{
    public partial class frmSplash : Form
    {
        Random random = new Random();
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
            if (carregamentoFalso.Value == 100)
            {
                calculadora frmTeste = new calculadora();
                frmTeste.Show();
                tmrLoading.Stop();
                this.Hide();
            }
        }
    }
}
