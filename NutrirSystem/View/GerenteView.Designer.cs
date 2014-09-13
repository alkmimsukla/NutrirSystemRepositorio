namespace View
{
    partial class GerenteView
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
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnRemoverFuncionario = new System.Windows.Forms.Button();
            this.btnAlterarFuncionario = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(12, 12);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(78, 67);
            this.btnCadastrarFuncionario.TabIndex = 0;
            this.btnCadastrarFuncionario.Text = "Cadastrar Funcionario";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            this.btnCadastrarFuncionario.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemoverFuncionario
            // 
            this.btnRemoverFuncionario.Location = new System.Drawing.Point(110, 12);
            this.btnRemoverFuncionario.Name = "btnRemoverFuncionario";
            this.btnRemoverFuncionario.Size = new System.Drawing.Size(78, 67);
            this.btnRemoverFuncionario.TabIndex = 1;
            this.btnRemoverFuncionario.Text = "Remover Funcionario";
            this.btnRemoverFuncionario.UseVisualStyleBackColor = true;
            this.btnRemoverFuncionario.Click += new System.EventHandler(this.btnRemoverFuncionario_Click);
            // 
            // btnAlterarFuncionario
            // 
            this.btnAlterarFuncionario.Location = new System.Drawing.Point(207, 12);
            this.btnAlterarFuncionario.Name = "btnAlterarFuncionario";
            this.btnAlterarFuncionario.Size = new System.Drawing.Size(78, 67);
            this.btnAlterarFuncionario.TabIndex = 2;
            this.btnAlterarFuncionario.Text = "Alterar Funcionario";
            this.btnAlterarFuncionario.UseVisualStyleBackColor = true;
            this.btnAlterarFuncionario.Click += new System.EventHandler(this.btnAlterarFuncionario_Click);
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(30, 394);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(103, 43);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 67);
            this.button1.TabIndex = 4;
            this.button1.Text = "Visualizar Funcionário";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GerenteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 470);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btnAlterarFuncionario);
            this.Controls.Add(this.btnRemoverFuncionario);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Name = "GerenteView";
            this.Text = "NutrirSystem - Gerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnRemoverFuncionario;
        private System.Windows.Forms.Button btnAlterarFuncionario;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button button1;
    }
}