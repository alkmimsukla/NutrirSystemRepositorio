namespace View
{
    partial class SecretariaView
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
            this.btnCadPaciente = new System.Windows.Forms.Button();
            this.btnAlterarPaciente = new System.Windows.Forms.Button();
            this.btnRemoverPaciente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadPaciente
            // 
            this.btnCadPaciente.Location = new System.Drawing.Point(13, 13);
            this.btnCadPaciente.Name = "btnCadPaciente";
            this.btnCadPaciente.Size = new System.Drawing.Size(83, 73);
            this.btnCadPaciente.TabIndex = 0;
            this.btnCadPaciente.Text = "Cadastrar Paciente";
            this.btnCadPaciente.UseVisualStyleBackColor = true;
            this.btnCadPaciente.Click += new System.EventHandler(this.btnCadPaciente_Click);
            // 
            // btnAlterarPaciente
            // 
            this.btnAlterarPaciente.Location = new System.Drawing.Point(118, 13);
            this.btnAlterarPaciente.Name = "btnAlterarPaciente";
            this.btnAlterarPaciente.Size = new System.Drawing.Size(83, 73);
            this.btnAlterarPaciente.TabIndex = 1;
            this.btnAlterarPaciente.Text = "Alterar Paciente";
            this.btnAlterarPaciente.UseVisualStyleBackColor = true;
            this.btnAlterarPaciente.Click += new System.EventHandler(this.btnAlterarPaciente_Click);
            // 
            // btnRemoverPaciente
            // 
            this.btnRemoverPaciente.Location = new System.Drawing.Point(230, 13);
            this.btnRemoverPaciente.Name = "btnRemoverPaciente";
            this.btnRemoverPaciente.Size = new System.Drawing.Size(83, 73);
            this.btnRemoverPaciente.TabIndex = 2;
            this.btnRemoverPaciente.Text = "Remover Paciente";
            this.btnRemoverPaciente.UseVisualStyleBackColor = true;
            this.btnRemoverPaciente.Click += new System.EventHandler(this.btnRemoverPaciente_Click);
            // 
            // SecretariaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.btnRemoverPaciente);
            this.Controls.Add(this.btnAlterarPaciente);
            this.Controls.Add(this.btnCadPaciente);
            this.Name = "SecretariaView";
            this.Text = "NutrirSystem - Secretária";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadPaciente;
        private System.Windows.Forms.Button btnAlterarPaciente;
        private System.Windows.Forms.Button btnRemoverPaciente;
    }
}