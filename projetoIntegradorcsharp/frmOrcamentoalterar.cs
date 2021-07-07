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
    public partial class frmOrcamentoalterar : Form
    {

        public frmOrcamentoalterar()
        {
            InitializeComponent();
        }

        private void frmOrcamentoalterar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string servico = "";
            if (rb_reformas.Checked)
            {
                servico = "reforma";
            }
            else if (rb_contrucao.Checked)
            {
                servico = "construcao";
            }
            string idOrcamento = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlBuscar = $"SELECT * FROM tb_arqorcamentos WHERE id={idOrcamento}";
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(sqlBuscar, conexao);
                da.Fill(dt);
                try
                {
                    txtNome.Text = (dt.Rows[0]["nome"].ToString());
                    txtTelefone.Text = (dt.Rows[0]["telefone"].ToString());
                    txtEmail.Text = (dt.Rows[0]["email"].ToString());
                    txtCidade.Text = (dt.Rows[0]["cidade"].ToString());
                    txtTerreno.Text = (dt.Rows[0]["terreno"].ToString());
                    txtConstrucao.Text = (dt.Rows[0]["construcao"].ToString());
                    txtComodos.Text = (dt.Rows[0]["comodos"].ToString());
                    servico = (dt.Rows[0]["servico"].ToString());
                    txtPreco.Text = (dt.Rows[0]["preco"].ToString());
                
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

        private void button3_Click(object sender, EventArgs e)
        {
            string servico = "";
            if (rb_reformas.Checked)
            {
                servico = "reforma";
            }
            else if (rb_contrucao.Checked)
            {
                servico = "construcao";
            }
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);

            try
            {
                conexao.Open();
                string mysqlAlterar = $"UPDATE tb_arqorcamentos set nome='{txtNome.Text}', telefone='{txtTelefone.Text}', email='{txtEmail.Text}', cidade='{txtCidade.Text}', terreno='{txtTerreno.Text}',construcao='{txtConstrucao.Text}', comodos='{txtComodos.Text}',servico='{servico}', preco='{txtPreco.Text}' WHERE id={txtID.Text}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = mysqlAlterar;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("alterado com sucesso");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("algum erro ocorreu. erro:" + erro.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valorP = Convert.ToDouble(txtTerreno.Text) * 30.00;
            double construcaoP = Convert.ToDouble(txtConstrucao.Text) * 10.00;
            double comodosP = Convert.ToDouble(txtComodos.Text) * 30.00;
            if (rb_contrucao.Checked == true)
            {
                double preco = construcaoP * 2 + valorP + comodosP;
                txtPreco.Text = preco.ToString();
            }
            else if (rb_reformas.Checked == true)
            {
                double preco = construcaoP * 1.5 + valorP + comodosP;
                txtPreco.Text = preco.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string idOrcamento = txtID.Text;
            string bancoDeDados = "server=localhost;user id=root;password=;database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                string sqlExcluir = $"DELETE FROM tb_arqorcamentos WHERE id={idOrcamento}";
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = sqlExcluir;
                cmd.ExecuteNonQuery();
                conexao.Close();
                MessageBox.Show("excluido com sucesso");
            }
            catch (MySqlException erro)
            {
                MessageBox.Show("erro de conexao. erro:" + erro.Message);
            }
}
    }
    }

