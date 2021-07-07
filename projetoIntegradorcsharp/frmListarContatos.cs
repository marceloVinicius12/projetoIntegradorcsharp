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
    public partial class frmListarContatos : Form
    {
        public frmListarContatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmContatos formulario = new frmContatos();
            formulario.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string bancoDeDados = "server=localhost; user id=root;password=; database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                string nomeBuscar = txtNomeBuscar.Text;
                conexao.Open();
                string sqlSelecionar = $"SELECT * FROM tb_arqcontatos WHERE nome LIKE '%{nomeBuscar}%'";
                MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                DataTable dt = new DataTable();
                da.Fill(dt);
                gridContatos.DataSource = dt;
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("a conexao falhor erro:" + erro.Message);
            }
        }
        private void frmListarContatos_Load(object sender, EventArgs e)
        
            {
                String bancoDeDados = "server=localhost; user id=root; password=; database=bd_arquitetura";
                MySqlConnection conexao = new MySqlConnection(bancoDeDados);
                try
                {
                    conexao.Open();
                    string sqlSelecionar = "SELECT * FROM tb_arqcontatos";
                    MySqlDataAdapter da = new MySqlDataAdapter(sqlSelecionar, conexao);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    gridContatos.DataSource = dt;
                    conexao.Close();
                }
                catch (MySqlException erro)
                {
                    MessageBox.Show("a conexao falhou. erro: " + erro.Message, "erro na conexao");
            }
        }

        private void gridContatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
