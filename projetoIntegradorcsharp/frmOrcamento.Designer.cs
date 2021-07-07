
namespace projetoIntegradorcsharp
{
    partial class frmOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrcamento));
            this.label1 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTerreno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtComodos = new System.Windows.Forms.TextBox();
            this.txtConstrucao = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_contrucao = new System.Windows.Forms.RadioButton();
            this.rb_reformas = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(112, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "nome :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // telefone
            // 
            this.telefone.AutoSize = true;
            this.telefone.BackColor = System.Drawing.Color.Transparent;
            this.telefone.CausesValidation = false;
            this.telefone.Location = new System.Drawing.Point(284, 80);
            this.telefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(78, 20);
            this.telefone.TabIndex = 1;
            this.telefone.Text = "telefone :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(481, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "email :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(686, 80);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "cidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(389, 305);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "preco";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(69, 105);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(148, 26);
            this.txtNome.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(247, 105);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(148, 26);
            this.txtTelefone.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(436, 105);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(148, 26);
            this.txtEmail.TabIndex = 3;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(632, 105);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(148, 26);
            this.txtCidade.TabIndex = 4;
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(339, 328);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(154, 26);
            this.txtPreco.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(353, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 49);
            this.button1.TabIndex = 26;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(33, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = " metragem do terreno (M²) :";
            // 
            // txtTerreno
            // 
            this.txtTerreno.Location = new System.Drawing.Point(69, 190);
            this.txtTerreno.Name = "txtTerreno";
            this.txtTerreno.Size = new System.Drawing.Size(145, 26);
            this.txtTerreno.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(616, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "quantidade de comodos ?";
            // 
            // txtComodos
            // 
            this.txtComodos.Location = new System.Drawing.Point(631, 181);
            this.txtComodos.Name = "txtComodos";
            this.txtComodos.Size = new System.Drawing.Size(146, 26);
            this.txtComodos.TabIndex = 7;
            // 
            // txtConstrucao
            // 
            this.txtConstrucao.Location = new System.Drawing.Point(339, 190);
            this.txtConstrucao.Name = "txtConstrucao";
            this.txtConstrucao.Size = new System.Drawing.Size(145, 26);
            this.txtConstrucao.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(284, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(233, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "metragem da contrução (M²) :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rb_contrucao);
            this.groupBox1.Controls.Add(this.rb_reformas);
            this.groupBox1.Location = new System.Drawing.Point(60, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "tipo de serviço ?";
            // 
            // rb_contrucao
            // 
            this.rb_contrucao.AutoSize = true;
            this.rb_contrucao.Location = new System.Drawing.Point(107, 26);
            this.rb_contrucao.Name = "rb_contrucao";
            this.rb_contrucao.Size = new System.Drawing.Size(106, 24);
            this.rb_contrucao.TabIndex = 1;
            this.rb_contrucao.TabStop = true;
            this.rb_contrucao.Text = "contrução ";
            this.rb_contrucao.UseVisualStyleBackColor = true;
            // 
            // rb_reformas
            // 
            this.rb_reformas.AutoSize = true;
            this.rb_reformas.Location = new System.Drawing.Point(7, 26);
            this.rb_reformas.Name = "rb_reformas";
            this.rb_reformas.Size = new System.Drawing.Size(94, 24);
            this.rb_reformas.TabIndex = 0;
            this.rb_reformas.TabStop = true;
            this.rb_reformas.Text = "reformas";
            this.rb_reformas.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(259, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 36);
            this.label2.TabIndex = 35;
            this.label2.Text = "orçamento clientes ";
            // 
            // frmOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(864, 425);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtConstrucao);
            this.Controls.Add(this.txtComodos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTerreno);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOrcamento";
            this.Text = "frmOrcamento";
            this.Load += new System.EventHandler(this.frmOrcamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTerreno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtComodos;
        private System.Windows.Forms.TextBox txtConstrucao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_reformas;
        private System.Windows.Forms.RadioButton rb_contrucao;
        private System.Windows.Forms.Label label2;
    }
}