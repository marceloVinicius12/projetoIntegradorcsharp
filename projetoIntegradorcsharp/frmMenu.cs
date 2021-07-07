using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoIntegradorcsharp
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void listarContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContatos formulario = new frmContatos();
            formulario.ShowDialog();
        }

        private void adicionarContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarContatos formulario = new frmListarContatos();
            formulario.ShowDialog();
        }

        private void alterarContatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlterarContatos formulario = new frmAlterarContatos();
            formulario.ShowDialog();
        }

        private void listarorcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamento formulario = new frmOrcamento();
            formulario.ShowDialog();
        }

        private void orcamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadeorçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarOrcamento formulario = new frmListarOrcamento();
            formulario.ShowDialog();
        }

        private void alterarorçamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrcamentoalterar formulario = new frmOrcamentoalterar();
            formulario.ShowDialog();
        }
    }
}
