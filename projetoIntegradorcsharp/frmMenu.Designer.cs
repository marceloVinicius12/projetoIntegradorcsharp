
namespace projetoIntegradorcsharp
{
    partial class frmMenu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarContatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orcamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarorcamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadeorçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarorçamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contatosToolStripMenuItem,
            this.orcamentoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contatosToolStripMenuItem
            // 
            this.contatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarContatosToolStripMenuItem,
            this.alterarContatosToolStripMenuItem,
            this.adicionarContatosToolStripMenuItem});
            this.contatosToolStripMenuItem.Name = "contatosToolStripMenuItem";
            this.contatosToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.contatosToolStripMenuItem.Text = "contatos";
            // 
            // listarContatosToolStripMenuItem
            // 
            this.listarContatosToolStripMenuItem.Name = "listarContatosToolStripMenuItem";
            this.listarContatosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listarContatosToolStripMenuItem.Text = "adicionar contatos";
            this.listarContatosToolStripMenuItem.Click += new System.EventHandler(this.listarContatosToolStripMenuItem_Click);
            // 
            // alterarContatosToolStripMenuItem
            // 
            this.alterarContatosToolStripMenuItem.Name = "alterarContatosToolStripMenuItem";
            this.alterarContatosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.alterarContatosToolStripMenuItem.Text = "alterar contatos";
            this.alterarContatosToolStripMenuItem.Click += new System.EventHandler(this.alterarContatosToolStripMenuItem_Click);
            // 
            // adicionarContatosToolStripMenuItem
            // 
            this.adicionarContatosToolStripMenuItem.Name = "adicionarContatosToolStripMenuItem";
            this.adicionarContatosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.adicionarContatosToolStripMenuItem.Text = "lista de  contatos";
            this.adicionarContatosToolStripMenuItem.Click += new System.EventHandler(this.adicionarContatosToolStripMenuItem_Click);
            // 
            // orcamentoToolStripMenuItem
            // 
            this.orcamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarorcamentoToolStripMenuItem,
            this.listadeorçamentosToolStripMenuItem,
            this.alterarorçamentosToolStripMenuItem});
            this.orcamentoToolStripMenuItem.Name = "orcamentoToolStripMenuItem";
            this.orcamentoToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.orcamentoToolStripMenuItem.Text = "orçamento";
            this.orcamentoToolStripMenuItem.Click += new System.EventHandler(this.orcamentoToolStripMenuItem_Click);
            // 
            // listarorcamentoToolStripMenuItem
            // 
            this.listarorcamentoToolStripMenuItem.Name = "listarorcamentoToolStripMenuItem";
            this.listarorcamentoToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listarorcamentoToolStripMenuItem.Text = "inserir-orcamento";
            this.listarorcamentoToolStripMenuItem.Click += new System.EventHandler(this.listarorcamentoToolStripMenuItem_Click);
            // 
            // listadeorçamentosToolStripMenuItem
            // 
            this.listadeorçamentosToolStripMenuItem.Name = "listadeorçamentosToolStripMenuItem";
            this.listadeorçamentosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.listadeorçamentosToolStripMenuItem.Text = "lista-de-orçamentos";
            this.listadeorçamentosToolStripMenuItem.Click += new System.EventHandler(this.listadeorçamentosToolStripMenuItem_Click);
            // 
            // alterarorçamentosToolStripMenuItem
            // 
            this.alterarorçamentosToolStripMenuItem.Name = "alterarorçamentosToolStripMenuItem";
            this.alterarorçamentosToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.alterarorçamentosToolStripMenuItem.Text = "alterar-orçamentos";
            this.alterarorçamentosToolStripMenuItem.Click += new System.EventHandler(this.alterarorçamentosToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(794, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarContatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarContatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarContatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orcamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarorcamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadeorçamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarorçamentosToolStripMenuItem;
    }
}

