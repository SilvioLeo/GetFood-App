using GetFood_App.DAL;
using GetFood_App.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFood_App.Aplicacao
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnMenuCadastrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            string menssagem = controle.CadastrarAlimentos(txtId.Text, txtAlimentos.Text, txtQuantidade.Text, dtpFabricacao.Text, dtpVencimento.Text);
            if (controle.tem)
            {
                MessageBox.Show(menssagem, "cadastrado com sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            Conexao con = new Conexao();
            SqlDataReader dr;
            DataTable dt = new DataTable();

            cmd.CommandText = "SELECT * FROM tabela_Alimentos";
            cmd.Connection = con.Conecta();
            dr = cmd.ExecuteReader();
            dt.Load(dr);

            dgvMenuAlimentos.DataSource = dt;

        }
    }
}
