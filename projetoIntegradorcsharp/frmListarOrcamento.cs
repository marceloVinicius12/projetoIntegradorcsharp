using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace projetoIntegradorcsharp
{
    public partial class frmListarOrcamento : Form
    {
        public frmListarOrcamento()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListarOrcamento_Load(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=; database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string slqSelecionar = "SELECT * FROM tb_arqorcamentos";
                MySqlDataAdapter da = new MySqlDataAdapter(slqSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_Orcamento.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("a conexao falhou. erro: " + erro.Message, "erro na conexao");
            }
        }

        private void txtNomeBuscar_TextChanged(object sender, EventArgs e)
        {
            string bancoDeDados= "server=localhost;user id=root;password=;database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_arqorcamentos WHERE nome LIKE '%{nomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                grid_Orcamento.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("a conexao falhor erro:" + erro.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmOrcamento formulario = new frmOrcamento();
            formulario.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}
