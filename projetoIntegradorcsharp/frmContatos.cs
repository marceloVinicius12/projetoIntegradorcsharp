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
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SalvarContato(txtNome.Text, txtEmail.Text, txtTelefone.Text, txtCidade.Text, txtAssunto.Text, txtMensagem.Text);
            LimparFormulario();
        }
        private void LimparFormulario()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            txtAssunto.Clear();
            txtMensagem.Clear();
        }
        private void SalvarContato(string nome, string email, string telefone, string cidade, string assunto, string mensagem)
        { 
            /* string de conexao */
            String BancodeDados = "server=localhost;user id=root; password=; database=bd_arquitetura";
            /* objeto de conexao */
            MySqlConnection conexao = new MySqlConnection(BancodeDados);
            /* tratamento de exceção */
            try
            {
                /* abertura da conexão */
                conexao.Open();
                /* objeto para armazenamento e execusao de sql */
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao; // informa o objeto de conexao para o cmd//
                /* informa o sql executado */
                cmd.CommandText = $"insert into tb_arqcontatos(nome, email , telefone , cidade , assunto , mensagem) values('{nome}', '{email}', '{telefone}', '{cidade}', '{assunto}', '{mensagem}')";
                /*  executar a função */
                cmd.ExecuteNonQuery();
                /* fechar a conexão */
                conexao.Close();

            }
            catch (MySqlException erro)
            {
                MessageBox.Show("ocorreu algum erro na execução do programa :" + erro.Message);
            }
        }
    }
    }


        


