namespace View.PacienteView
{
    partial class visualizarPacienteView
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
            this.btBuscarPacienteVisualizar = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEsportesPraticados = new System.Windows.Forms.Label();
            this.textBoxesportesPraticados = new System.Windows.Forms.TextBox();
            this.lbObjetivos = new System.Windows.Forms.Label();
            this.campoObjetivoAlteracao = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.campoTpSangAlteracao = new System.Windows.Forms.ComboBox();
            this.campoDtNascAlteracao = new System.Windows.Forms.MonthCalendar();
            this.label18 = new System.Windows.Forms.Label();
            this.campoEstadoAlteracao = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.campoCidadeAlteracao = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.campoEmailAlteracao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.campoNumeroAlteracao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.campoRuaAlteracao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.campoBairroAlteracao = new System.Windows.Forms.TextBox();
            this.campoCelularAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.campoTelefoneAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.campoSexoAlteracao = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoApelidoAlteracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.campoNomeAlteracao = new System.Windows.Forms.TextBox();
            this.btVoltarVisualizacao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.campoCPFVisualizacao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBuscarPacienteVisualizar
            // 
            this.btBuscarPacienteVisualizar.Location = new System.Drawing.Point(389, 64);
            this.btBuscarPacienteVisualizar.Name = "btBuscarPacienteVisualizar";
            this.btBuscarPacienteVisualizar.Size = new System.Drawing.Size(75, 23);
            this.btBuscarPacienteVisualizar.TabIndex = 46;
            this.btBuscarPacienteVisualizar.Text = "Buscar";
            this.btBuscarPacienteVisualizar.UseVisualStyleBackColor = true;
            this.btBuscarPacienteVisualizar.Click += new System.EventHandler(this.btBuscarAlteracao_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(188, 24);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(219, 13);
            this.label16.TabIndex = 45;
            this.label16.Text = "Digite o CPF do Paciente para alterar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelEsportesPraticados);
            this.panel1.Controls.Add(this.textBoxesportesPraticados);
            this.panel1.Controls.Add(this.lbObjetivos);
            this.panel1.Controls.Add(this.campoObjetivoAlteracao);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.campoTpSangAlteracao);
            this.panel1.Controls.Add(this.campoDtNascAlteracao);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.campoEstadoAlteracao);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.campoCidadeAlteracao);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.campoEmailAlteracao);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.campoNumeroAlteracao);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.campoRuaAlteracao);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.campoBairroAlteracao);
            this.panel1.Controls.Add(this.campoCelularAlteracao);
            this.panel1.Controls.Add(this.campoTelefoneAlteracao);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.campoSexoAlteracao);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.campoApelidoAlteracao);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.campoNomeAlteracao);
            this.panel1.Location = new System.Drawing.Point(12, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(841, 337);
            this.panel1.TabIndex = 42;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelEsportesPraticados
            // 
            this.labelEsportesPraticados.AutoSize = true;
            this.labelEsportesPraticados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEsportesPraticados.Location = new System.Drawing.Point(558, 226);
            this.labelEsportesPraticados.Name = "labelEsportesPraticados";
            this.labelEsportesPraticados.Size = new System.Drawing.Size(120, 13);
            this.labelEsportesPraticados.TabIndex = 83;
            this.labelEsportesPraticados.Text = "Esportes Praticados";
            // 
            // textBoxesportesPraticados
            // 
            this.textBoxesportesPraticados.Location = new System.Drawing.Point(561, 245);
            this.textBoxesportesPraticados.Multiline = true;
            this.textBoxesportesPraticados.Name = "textBoxesportesPraticados";
            this.textBoxesportesPraticados.Size = new System.Drawing.Size(222, 64);
            this.textBoxesportesPraticados.TabIndex = 82;
            // 
            // lbObjetivos
            // 
            this.lbObjetivos.AutoSize = true;
            this.lbObjetivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbObjetivos.Location = new System.Drawing.Point(278, 225);
            this.lbObjetivos.Name = "lbObjetivos";
            this.lbObjetivos.Size = new System.Drawing.Size(54, 13);
            this.lbObjetivos.TabIndex = 81;
            this.lbObjetivos.Text = "Objetivo";
            // 
            // campoObjetivoAlteracao
            // 
            this.campoObjetivoAlteracao.Location = new System.Drawing.Point(281, 245);
            this.campoObjetivoAlteracao.Multiline = true;
            this.campoObjetivoAlteracao.Name = "campoObjetivoAlteracao";
            this.campoObjetivoAlteracao.Size = new System.Drawing.Size(212, 63);
            this.campoObjetivoAlteracao.TabIndex = 80;
            this.campoObjetivoAlteracao.TextChanged += new System.EventHandler(this.campoObjetivoAlteracao_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 271);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Tipo Sanguineo";
            // 
            // campoTpSangAlteracao
            // 
            this.campoTpSangAlteracao.FormattingEnabled = true;
            this.campoTpSangAlteracao.Location = new System.Drawing.Point(18, 287);
            this.campoTpSangAlteracao.Name = "campoTpSangAlteracao";
            this.campoTpSangAlteracao.Size = new System.Drawing.Size(121, 21);
            this.campoTpSangAlteracao.TabIndex = 78;
            // 
            // campoDtNascAlteracao
            // 
            this.campoDtNascAlteracao.Location = new System.Drawing.Point(447, 33);
            this.campoDtNascAlteracao.Name = "campoDtNascAlteracao";
            this.campoDtNascAlteracao.TabIndex = 77;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(278, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "Estado";
            // 
            // campoEstadoAlteracao
            // 
            this.campoEstadoAlteracao.Location = new System.Drawing.Point(281, 202);
            this.campoEstadoAlteracao.Name = "campoEstadoAlteracao";
            this.campoEstadoAlteracao.Size = new System.Drawing.Size(143, 20);
            this.campoEstadoAlteracao.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(278, 145);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 74;
            this.label17.Text = "Cidade";
            // 
            // campoCidadeAlteracao
            // 
            this.campoCidadeAlteracao.Location = new System.Drawing.Point(281, 161);
            this.campoCidadeAlteracao.Name = "campoCidadeAlteracao";
            this.campoCidadeAlteracao.Size = new System.Drawing.Size(143, 20);
            this.campoCidadeAlteracao.TabIndex = 73;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(19, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "Email";
            // 
            // campoEmailAlteracao
            // 
            this.campoEmailAlteracao.Location = new System.Drawing.Point(19, 202);
            this.campoEmailAlteracao.Name = "campoEmailAlteracao";
            this.campoEmailAlteracao.Size = new System.Drawing.Size(248, 20);
            this.campoEmailAlteracao.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 65;
            this.label13.Text = "Numero";
            // 
            // campoNumeroAlteracao
            // 
            this.campoNumeroAlteracao.Location = new System.Drawing.Point(281, 121);
            this.campoNumeroAlteracao.Name = "campoNumeroAlteracao";
            this.campoNumeroAlteracao.Size = new System.Drawing.Size(143, 20);
            this.campoNumeroAlteracao.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Rua";
            // 
            // campoRuaAlteracao
            // 
            this.campoRuaAlteracao.Location = new System.Drawing.Point(18, 121);
            this.campoRuaAlteracao.Name = "campoRuaAlteracao";
            this.campoRuaAlteracao.Size = new System.Drawing.Size(249, 20);
            this.campoRuaAlteracao.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Bairro";
            // 
            // campoBairroAlteracao
            // 
            this.campoBairroAlteracao.Location = new System.Drawing.Point(18, 161);
            this.campoBairroAlteracao.Name = "campoBairroAlteracao";
            this.campoBairroAlteracao.Size = new System.Drawing.Size(249, 20);
            this.campoBairroAlteracao.TabIndex = 58;
            // 
            // campoCelularAlteracao
            // 
            this.campoCelularAlteracao.Location = new System.Drawing.Point(281, 75);
            this.campoCelularAlteracao.Mask = "(99) 0000-0000";
            this.campoCelularAlteracao.Name = "campoCelularAlteracao";
            this.campoCelularAlteracao.Size = new System.Drawing.Size(146, 20);
            this.campoCelularAlteracao.TabIndex = 55;
            // 
            // campoTelefoneAlteracao
            // 
            this.campoTelefoneAlteracao.Location = new System.Drawing.Point(281, 33);
            this.campoTelefoneAlteracao.Mask = "(99) 0000-0000";
            this.campoTelefoneAlteracao.Name = "campoTelefoneAlteracao";
            this.campoTelefoneAlteracao.Size = new System.Drawing.Size(146, 20);
            this.campoTelefoneAlteracao.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Sexo";
            // 
            // campoSexoAlteracao
            // 
            this.campoSexoAlteracao.FormattingEnabled = true;
            this.campoSexoAlteracao.Location = new System.Drawing.Point(18, 244);
            this.campoSexoAlteracao.Name = "campoSexoAlteracao";
            this.campoSexoAlteracao.Size = new System.Drawing.Size(103, 21);
            this.campoSexoAlteracao.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(444, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Data de Nascimento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Celular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(281, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Apelido";
            // 
            // campoApelidoAlteracao
            // 
            this.campoApelidoAlteracao.Location = new System.Drawing.Point(19, 74);
            this.campoApelidoAlteracao.Name = "campoApelidoAlteracao";
            this.campoApelidoAlteracao.Size = new System.Drawing.Size(248, 20);
            this.campoApelidoAlteracao.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Nome";
            // 
            // campoNomeAlteracao
            // 
            this.campoNomeAlteracao.Location = new System.Drawing.Point(18, 33);
            this.campoNomeAlteracao.Name = "campoNomeAlteracao";
            this.campoNomeAlteracao.Size = new System.Drawing.Size(246, 20);
            this.campoNomeAlteracao.TabIndex = 40;
            // 
            // btVoltarVisualizacao
            // 
            this.btVoltarVisualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltarVisualizacao.Location = new System.Drawing.Point(671, 444);
            this.btVoltarVisualizacao.Name = "btVoltarVisualizacao";
            this.btVoltarVisualizacao.Size = new System.Drawing.Size(101, 42);
            this.btVoltarVisualizacao.TabIndex = 72;
            this.btVoltarVisualizacao.Text = "Voltar";
            this.btVoltarVisualizacao.UseVisualStyleBackColor = true;
            this.btVoltarVisualizacao.Click += new System.EventHandler(this.btVoltarVisualizacao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "CPF";
            // 
            // campoCPFVisualizacao
            // 
            this.campoCPFVisualizacao.Location = new System.Drawing.Point(187, 67);
            this.campoCPFVisualizacao.Name = "campoCPFVisualizacao";
            this.campoCPFVisualizacao.Size = new System.Drawing.Size(135, 20);
            this.campoCPFVisualizacao.TabIndex = 43;
            this.campoCPFVisualizacao.KeyUp += new System.Windows.Forms.KeyEventHandler(this.campoCPFVisualizacao_KeyUp);
            // 
            // visualizarPacienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 498);
            this.Controls.Add(this.btBuscarPacienteVisualizar);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoCPFVisualizacao);
            this.Controls.Add(this.btVoltarVisualizacao);
            this.Name = "visualizarPacienteView";
            this.Text = "Visualizar Paciente - Secretária";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscarPacienteVisualizar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbObjetivos;
        private System.Windows.Forms.TextBox campoObjetivoAlteracao;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox campoTpSangAlteracao;
        private System.Windows.Forms.MonthCalendar campoDtNascAlteracao;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox campoEstadoAlteracao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox campoCidadeAlteracao;
        private System.Windows.Forms.Button btVoltarVisualizacao;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox campoEmailAlteracao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox campoNumeroAlteracao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox campoRuaAlteracao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox campoBairroAlteracao;
        private System.Windows.Forms.MaskedTextBox campoCelularAlteracao;
        private System.Windows.Forms.MaskedTextBox campoTelefoneAlteracao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox campoSexoAlteracao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoApelidoAlteracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox campoNomeAlteracao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox campoCPFVisualizacao;
        private System.Windows.Forms.Label labelEsportesPraticados;
        private System.Windows.Forms.TextBox textBoxesportesPraticados;

    }
}