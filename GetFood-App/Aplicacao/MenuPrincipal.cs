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
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        SqlDataReader dr;
        DataTable dt = new DataTable();
        bool tem = false;
        string menssagem = "";

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
                MostrarGrid();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            MostrarGrid();

        }

        public void MostrarGrid()
        {
            
            cmd.CommandText = "SELECT * FROM tabela_Alimentos";
            cmd.Connection = con.Conecta();
            dr = cmd.ExecuteReader();
            dt.Load(dr);

            dgvMenuAlimentos.DataSource = dt;
            dgvMenuAlimentos.AutoResizeRows();

        }

        private void dgvMenuAlimentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*string idClicado;
            idClicado = Convert.ToString(dgvMenuAlimentos.Rows[e.RowIndex].Cells[0].Value);

            cmd.CommandText = "SELECT * FROM tabela_Alimentos WHERE id = @idl";
            cmd.Connection = con.Conecta();

            cmd.Parameters.AddWithValue("@idl", SqlDbType.VarChar).Value = idClicado;

            dr = cmd.ExecuteReader();

            dr.Read();

            txtId.Text = Convert.ToString(dr["id"]);
            txtAlimentos.Text = Convert.ToString(dr["alimento"]);
            txtQuantidade.Text = Convert.ToString(dr["quantidade"]);
            dtpFabricacao.Text = Convert.ToString(dr["dataFabricacao"]);
            dtpVencimento.Text = Convert.ToString(dr["dataVencimento"]);
            con.Desconectar();
            dr.Close();*/
        }

        private void btnMenuConsultar_Click(object sender, EventArgs e)
        {


        }

 
    }
}
