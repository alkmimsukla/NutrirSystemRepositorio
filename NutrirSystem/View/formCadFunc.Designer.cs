namespace View
{
    partial class formCadFunc
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
            this.boxCpf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.boxApelido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6CRM = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.calendarDN = new System.Windows.Forms.MonthCalendar();
            this.cbBoxSexo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxLogin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbBoxPerfil = new System.Windows.Forms.ComboBox();
            this.bttGravar = new System.Windows.Forms.Button();
            this.masktbCRM = new System.Windows.Forms.MaskedTextBox();
            this.mkBoxTel = new System.Windows.Forms.MaskedTextBox();
            this.mkBoxCel = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxCpf
            // 
            this.boxCpf.Location = new System.Drawing.Point(12, 31);
            this.boxCpf.Name = "boxCpf";
            this.boxCpf.Size = new System.Drawing.Size(163, 20);
            this.boxCpf.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPF";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // boxNome
            // 
            this.boxNome.Location = new System.Drawing.Point(12, 150);
            this.boxNome.Name = "boxNome";
            this.boxNome.Size = new System.Drawing.Size(252, 20);
            this.boxNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apelido";
            // 
            // boxApelido
            // 
            this.boxApelido.Location = new System.Drawing.Point(12, 214);
            this.boxApelido.Name = "boxApelido";
            this.boxApelido.Size = new System.Drawing.Size(252, 20);
            this.boxApelido.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(295, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(295, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Celular";
            // 
            // label6CRM
            // 
            this.label6CRM.AutoSize = true;
            this.label6CRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6CRM.Location = new System.Drawing.Point(12, 255);
            this.label6CRM.Name = "label6CRM";
            this.label6CRM.Size = new System.Drawing.Size(34, 13);
            this.label6CRM.TabIndex = 11;
            this.label6CRM.Text = "CRM";
            this.label6CRM.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(467, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Data de Nacimento";
            // 
            // calendarDN
            // 
            this.calendarDN.Location = new System.Drawing.Point(470, 86);
            this.calendarDN.Name = "calendarDN";
            this.calendarDN.TabIndex = 13;
            // 
            // cbBoxSexo
            // 
            this.cbBoxSexo.FormattingEnabled = true;
            this.cbBoxSexo.Location = new System.Drawing.Point(298, 270);
            this.cbBoxSexo.Name = "cbBoxSexo";
            this.cbBoxSexo.Size = new System.Drawing.Size(143, 21);
            this.cbBoxSexo.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(295, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sexo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Login";
            // 
            // boxLogin
            // 
            this.boxLogin.Location = new System.Drawing.Point(12, 87);
            this.boxLogin.Name = "boxLogin";
            this.boxLogin.Size = new System.Drawing.Size(252, 20);
            this.boxLogin.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(292, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Perfil";
            // 
            // cbBoxPerfil
            // 
            this.cbBoxPerfil.FormattingEnabled = true;
            this.cbBoxPerfil.Location = new System.Drawing.Point(295, 31);
            this.cbBoxPerfil.Name = "cbBoxPerfil";
            this.cbBoxPerfil.Size = new System.Drawing.Size(143, 21);
            this.cbBoxPerfil.TabIndex = 18;
            this.cbBoxPerfil.SelectionChangeCommitted += new System.EventHandler(this.cbPerfilChange);
            // 
            // bttGravar
            // 
            this.bttGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttGravar.Location = new System.Drawing.Point(474, 275);
            this.bttGravar.Name = "bttGravar";
            this.bttGravar.Size = new System.Drawing.Size(203, 51);
            this.bttGravar.TabIndex = 20;
            this.bttGravar.Text = "Gravar";
            this.bttGravar.UseVisualStyleBackColor = true;
            // 
            // masktbCRM
            // 
            this.masktbCRM.Location = new System.Drawing.Point(15, 270);
            this.masktbCRM.Mask = "0000000";
            this.masktbCRM.Name = "masktbCRM";
            this.masktbCRM.Size = new System.Drawing.Size(249, 20);
            this.masktbCRM.TabIndex = 21;
            this.masktbCRM.Visible = false;
            // 
            // mkBoxTel
            // 
            this.mkBoxTel.Location = new System.Drawing.Point(295, 150);
            this.mkBoxTel.Mask = "(99) 0000-0000";
            this.mkBoxTel.Name = "mkBoxTel";
            this.mkBoxTel.Size = new System.Drawing.Size(146, 20);
            this.mkBoxTel.TabIndex = 22;
            // 
            // mkBoxCel
            // 
            this.mkBoxCel.Location = new System.Drawing.Point(295, 214);
            this.mkBoxCel.Mask = "(99) 0000-0000";
            this.mkBoxCel.Name = "mkBoxCel";
            this.mkBoxCel.Size = new System.Drawing.Size(146, 20);
            this.mkBoxCel.TabIndex = 23;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(295, 86);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PasswordChar = '*';
            this.maskedTextBox2.Size = new System.Drawing.Size(146, 20);
            this.maskedTextBox2.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(292, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Senha";
            // 
            // formCadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 343);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.mkBoxCel);
            this.Controls.Add(this.mkBoxTel);
            this.Controls.Add(this.masktbCRM);
            this.Controls.Add(this.bttGravar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cbBoxPerfil);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.boxLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbBoxSexo);
            this.Controls.Add(this.calendarDN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6CRM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxApelido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxCpf);
            this.Name = "formCadFunc";
            this.Text = "Cadastro de Funcionario";
            this.Load += new System.EventHandler(this.formCadFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxCpf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox boxApelido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6CRM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MonthCalendar calendarDN;
        private System.Windows.Forms.ComboBox cbBoxSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox boxLogin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbBoxPerfil;
        private System.Windows.Forms.Button bttGravar;
        private System.Windows.Forms.MaskedTextBox masktbCRM;
        private System.Windows.Forms.MaskedTextBox mkBoxTel;
        private System.Windows.Forms.MaskedTextBox mkBoxCel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label11;
    }
}