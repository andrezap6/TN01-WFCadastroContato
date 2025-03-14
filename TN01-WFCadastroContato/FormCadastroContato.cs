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
        public void Sucesso(string mensagem = "")
        {
            MessageBox.Show(mensagem, "Sucesso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void LimparFormulario()
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            mtdTelefone.Clear();
            rdbPessoal.Checked = false;
            rdbComercial.Checked = false;
            rdbRecado.Checked = false;
            txtEmail.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string sobrenome = txtSobrenome.Text;
            string telefone = mtdTelefone.Text;
            ETipoTelefone tipotelefone;

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
                tipotelefone = ETipoTelefone.Pessoal;
            }
            else if (rdbComercial.Checked)
            {
                tipotelefone = ETipoTelefone.Comercial;
            }
            else if (rdbRecado.Checked)
            {
                tipotelefone = ETipoTelefone.Recado;
            }
            else
            {
                MessageBox.Show("O tipo de telefone não foi informado", "Erro");
                return;
            }

            Contato c1 = new Contato();
            c1.Nome = nome;
            c1.Email = email;
            c1.Sobrenome = sobrenome;
            c1.Codigo = 0;
            c1.TipoTelefone = tipotelefone;
            c1.DDD = mtdTelefone.Text.Substring(0, 2);
            c1.Telefone = mtdTelefone.Text.Substring(5);

            Contato.ListaContatos.Add(c1);

            Sucesso("Cadastrado com Sucesso!");

            LimparFormulario();
        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
