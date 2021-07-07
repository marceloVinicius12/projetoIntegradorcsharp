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
    public partial class frmOrcamento : Form
    {
        public object rb_servico { get; private set; }

        public frmOrcamento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmOrcamento_Load(object sender, EventArgs e)
        {

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            string servico = "";
            if (rb_reformas.Checked )
            {
                servico = "reforma";
            }
            else if (rb_contrucao.Checked)
            {
                servico = "construcao";
            }
            double valorP = Convert.ToDouble(txtTerreno.Text) * 30.00;
            double construcaoP = Convert.ToDouble(txtConstrucao.Text) * 10.00;
            double comodosP = Convert.ToDouble(txtComodos.Text) * 30.00;
            if(rb_contrucao.Checked == true)
            {
                double preco = construcaoP * 2 + valorP + comodosP;
                txtPreco.Text = preco.ToString();
            }
            else if(rb_reformas.Checked == true)
            {
                double preco = construcaoP * 1.5 + valorP + comodosP;
                txtPreco.Text = preco.ToString();
            }
            SalvarOrcamento(txtNome.Text, txtTelefone.Text, txtEmail.Text, txtCidade.Text, txtTerreno.Text, txtConstrucao.Text, txtComodos.Text, servico ,  txtPreco.Text) ;
            
        }
        private void limparOrcamento()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtTerreno.Clear();
            txtConstrucao.Clear();
            txtComodos.Clear();
            txtPreco.Clear();
        }
        private void SalvarOrcamento(string nome, string telefone, string email, string cidade, string terreno, string construcao,string comodos, string servico, string preco)
        {
            string bancoDeDados = "server=localhost;user id=root; password=; database=bd_arquitetura";
            MySqlConnection conexao = new MySqlConnection(bancoDeDados);
            try
            {
                conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = $"INSERT into  tb_arqorcamentos(nome, telefone, email, cidade , terreno, construcao ,comodos,servico,preco)values('{nome}','{telefone}', '{email}','{cidade}','{terreno}','{construcao}','{comodos}','{servico}',{preco})";
                cmd.ExecuteNonQuery();
                conexao.Close();
            }catch(Exception erro)
            {
                MessageBox.Show("ocorreu algum erro na execução do programa :" + erro.Message);
            }


            }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
      
    }

