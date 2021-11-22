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

namespace GetFood_App.Aplicacao
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            String menssagem = controle.Cadastrar(txtCadEmail.Text, txtCadSenha.Text, textCadConfSenha.Text);
            if (controle.tem)
            {
                MessageBox.Show(menssagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MenuPrincipal menuPrincipal = new MenuPrincipal();
                menuPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }
        }

        private void btnCadSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCadVoltar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
     
        }
    }
}
