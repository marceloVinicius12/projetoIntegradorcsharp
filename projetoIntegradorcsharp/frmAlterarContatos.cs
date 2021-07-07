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
    public partial class frmAlterarContatos : Form
    {
        public frmAlterarContatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idContatos = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;password=; database=bd_arquitetura;";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlBuscar = $" SELECT * FROM tb_arqcontatos WHERE id={idContatos}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                try
                {
                    txtNome.Text = (dt.Rows[0]["nome"].ToString());
                    txtEmail.Text = (dt.Rows[0]["email"].ToString());
                    txtTelefone.Text = (dt.Rows[0]["telefone"].ToString());
                    txtCidade.Text = (dt.Rows[0]["cidade"].ToString());
                    txtAssunto.Text = (dt.Rows[0]["assunto"].ToString());
                    txtMensagem.Text = (dt.Rows[0]["mensagem"].ToString());

                }
                catch (Exception)
                {
                    MessageBox.Show("Atenção o ID inserido é invalido");
                }
                conexao.Close();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("Algo errado com a conexão. erro:" + erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root; password=;database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlAlterar = $"UPDATE tb_arqcontatos set nome='{txtNome.Text}',email='{txtEmail.Text}', telefone='{txtTelefone.Text}', cidade='{txtCidade.Text}', assunto='{txtAssunto.Text}', mensagem ='{txtMensagem.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("alterado com sucesso");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("algum erro ocorreu. erro:" + erro.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_arquitetura";
            string idContato = txtID.Text;
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_arqcontatos WHERE id={idContato}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("contato excluido com sucesso");
                txtNome.Clear();
                txtID.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCidade.Clear();
                txtAssunto.Clear();
                txtMensagem.Clear();
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("erro de conexao. erro:" + erro.Message);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    

