using GetFood_App.Aplicacao;
using GetFood_App.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFood_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogCadastreSe_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }

        private void btnLogSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txtEmail.Text, txtSenha.Text);
            if (controle.menssagem.Equals(""))
            {
                if (controle.tem)
                {
                    MessageBox.Show("Logado com sucesso", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuPrincipal menu = new MenuPrincipal();
                    menu.Show();
                }
                else
                {
                    MessageBox.Show("Login não encontrado verifique se o email ou senha estão corretos ", "ERRO!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
