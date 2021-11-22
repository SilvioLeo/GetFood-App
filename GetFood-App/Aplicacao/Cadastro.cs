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

            }
            else
            {
                MessageBox.Show(controle.menssagem);
            }
        }
    }
}
