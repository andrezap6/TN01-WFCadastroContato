using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TN01_WFCadastroContato
{
    public partial class FormCadastroContato : Form
    {
        public FormCadastroContato()
        {
            InitializeComponent();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mkdTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
        }
        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = mkdTelefone.Text;
            string email = txtEmail.Text;

            if (nome.Length == 0)
            {
                MessageBox.Show("O nome no foi informado", "Erro"); return;
            }
            if (sobrenome.Length == 0)
            {
                MessageBox.Show("O sobrenome não foi informado", "Erro"); return;
            }
            if (email.Length == 0)
            {
                MessageBox.Show("E-mail", "Erro"); return;
            }
            if (telefone.Length == 0)
            {
                MessageBox.Show("O telefone não foi informado", "Erro"); return;
            }

            if (rdbPessoal.Checked)
            {
                telefone = "P";
            }
            else if (rdbComercial.Checked)
            {
                telefone = "C";
            }
            else if (rdbComercial.Checked)
            {
                telefone = "R";
            }
        }
    }
}
