namespace View.ProdutosView
{
    partial class cadastrarProdutoView
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
            this.btnGravarProdutos = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFibra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSodio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCarboidratos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGordura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravarProdutos
            // 
            this.btnGravarProdutos.Location = new System.Drawing.Point(116, 205);
            this.btnGravarProdutos.Name = "btnGravarProdutos";
            this.btnGravarProdutos.Size = new System.Drawing.Size(95, 23);
            this.btnGravarProdutos.TabIndex = 5;
            this.btnGravarProdutos.Text = "Gravar";
            this.btnGravarProdutos.UseVisualStyleBackColor = true;
            this.btnGravarProdutos.Click += new System.EventHandler(this.btnGravarProdutos_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(156, 53);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(100, 20);
            this.txtNomeProduto.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite o nome do Produto para cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fibra";
            // 
            // txtFibra
            // 
            this.txtFibra.Location = new System.Drawing.Point(116, 16);
            this.txtFibra.Name = "txtFibra";
            this.txtFibra.Size = new System.Drawing.Size(100, 20);
            this.txtFibra.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sódio";
            // 
            // txtSodio
            // 
            this.txtSodio.Location = new System.Drawing.Point(116, 55);
            this.txtSodio.Name = "txtSodio";
            this.txtSodio.Size = new System.Drawing.Size(100, 20);
            this.txtSodio.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Carboidratos";
            // 
            // txtCarboidratos
            // 
            this.txtCarboidratos.Location = new System.Drawing.Point(116, 90);
            this.txtCarboidratos.Name = "txtCarboidratos";
            this.txtCarboidratos.Size = new System.Drawing.Size(100, 20);
            this.txtCarboidratos.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gordura";
            // 
            // txtGordura
            // 
            this.txtGordura.Location = new System.Drawing.Point(116, 125);
            this.txtGordura.Name = "txtGordura";
            this.txtGordura.Size = new System.Drawing.Size(100, 20);
            this.txtGordura.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFibra);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSodio);
            this.panel1.Controls.Add(this.txtGordura);
            this.panel1.Controls.Add(this.btnGravarProdutos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCarboidratos);
            this.panel1.Location = new System.Drawing.Point(58, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 280);
            this.panel1.TabIndex = 12;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(871, 424);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // cadastrarProdutoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 483);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.Name = "cadastrarProdutoView";
            this.Text = "Cadastrar Produto";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGravarProdutos;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFibra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSodio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCarboidratos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGordura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVoltar;
    }
}