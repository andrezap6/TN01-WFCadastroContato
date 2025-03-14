namespace TN01_WFCadastroContato
{
    public partial class lblMenuPrincipal : Form
    {
        public lblMenuPrincipal()
        {
            InitializeComponent();
        }

        private void mnsSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnsCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastroContato form = new FormCadastroContato();
            form.ShowDialog();
        }

        private void mnsListagem_Click(object sender, EventArgs e)
        {
            FormListagem form = new FormListagem();
            form.ShowDialog();
        }
    }
}
