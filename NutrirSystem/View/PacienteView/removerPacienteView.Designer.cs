namespace View.PacienteView
{
    partial class removerPacienteView
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblConvenioChBox = new System.Windows.Forms.Label();
            this.chbConvenio = new System.Windows.Forms.CheckBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblNumConvenio = new System.Windows.Forms.Label();
            this.txtNomeConvenio = new System.Windows.Forms.TextBox();
            this.txtNumConvenio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTipoSanguineo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtObjetivo = new System.Windows.Forms.TextBox();
            this.btnRemoverPaciente = new System.Windows.Forms.Button();
            this.lblEsportes = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btBuscarRemocao = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.campoCPFRemocao = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ucEndereco1 = new View.UserControls.ucEndereco();
            this.ucPessoa1 = new View.UserControls.ucPessoa();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(689, 231);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(82, 49);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // textBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 6);
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(128, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.tableLayoutPanel1.SetRowSpan(this.textBox1, 2);
            this.textBox1.Size = new System.Drawing.Size(643, 70);
            this.textBox1.TabIndex = 13;
            // 
            // lblConvenioChBox
            // 
            this.lblConvenioChBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConvenioChBox.AutoSize = true;
            this.lblConvenioChBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenioChBox.Location = new System.Drawing.Point(50, 3);
            this.lblConvenioChBox.Name = "lblConvenioChBox";
            this.lblConvenioChBox.Size = new System.Drawing.Size(72, 32);
            this.lblConvenioChBox.TabIndex = 0;
            this.lblConvenioChBox.Text = "Possui Convênio?";
            // 
            // chbConvenio
            // 
            this.chbConvenio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chbConvenio.AutoSize = true;
            this.chbConvenio.Location = new System.Drawing.Point(170, 12);
            this.chbConvenio.Name = "chbConvenio";
            this.chbConvenio.Size = new System.Drawing.Size(15, 14);
            this.chbConvenio.TabIndex = 1;
            this.chbConvenio.UseVisualStyleBackColor = true;
            // 
            // lblConvenio
            // 
            this.lblConvenio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConvenio.Location = new System.Drawing.Point(267, 3);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(65, 32);
            this.lblConvenio.TabIndex = 2;
            this.lblConvenio.Text = "Nome Convênio";
            // 
            // lblNumConvenio
            // 
            this.lblNumConvenio.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNumConvenio.AutoSize = true;
            this.lblNumConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumConvenio.Location = new System.Drawing.Point(627, 11);
            this.lblNumConvenio.Name = "lblNumConvenio";
            this.lblNumConvenio.Size = new System.Drawing.Size(56, 16);
            this.lblNumConvenio.TabIndex = 3;
            this.lblNumConvenio.Text = "Número";
            // 
            // txtNomeConvenio
            // 
            this.txtNomeConvenio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.SetColumnSpan(this.txtNomeConvenio, 2);
            this.txtNomeConvenio.Location = new System.Drawing.Point(338, 9);
            this.txtNomeConvenio.Name = "txtNomeConvenio";
            this.txtNomeConvenio.Size = new System.Drawing.Size(200, 20);
            this.txtNomeConvenio.TabIndex = 4;
            // 
            // txtNumConvenio
            // 
            this.txtNumConvenio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNumConvenio.Location = new System.Drawing.Point(689, 9);
            this.txtNumConvenio.Name = "txtNumConvenio";
            this.txtNumConvenio.Size = new System.Drawing.Size(82, 20);
            this.txtNumConvenio.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tipo Sanguineo";
            // 
            // cmbTipoSanguineo
            // 
            this.cmbTipoSanguineo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbTipoSanguineo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoSanguineo.FormattingEnabled = true;
            this.cmbTipoSanguineo.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "O+",
            "O-",
            "AB+",
            "AB-"});
            this.cmbTipoSanguineo.Location = new System.Drawing.Point(128, 45);
            this.cmbTipoSanguineo.Name = "cmbTipoSanguineo";
            this.cmbTipoSanguineo.Size = new System.Drawing.Size(99, 24);
            this.cmbTipoSanguineo.TabIndex = 8;
            this.cmbTipoSanguineo.Text = "Selecione..";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Objetivo";
            // 
            // txtObjetivo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtObjetivo, 6);
            this.txtObjetivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObjetivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObjetivo.Location = new System.Drawing.Point(128, 155);
            this.txtObjetivo.Multiline = true;
            this.txtObjetivo.Name = "txtObjetivo";
            this.tableLayoutPanel1.SetRowSpan(this.txtObjetivo, 2);
            this.txtObjetivo.Size = new System.Drawing.Size(643, 70);
            this.txtObjetivo.TabIndex = 10;
            // 
            // btnRemoverPaciente
            // 
            this.btnRemoverPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoverPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPaciente.Location = new System.Drawing.Point(777, 231);
            this.btnRemoverPaciente.Name = "btnRemoverPaciente";
            this.btnRemoverPaciente.Size = new System.Drawing.Size(79, 49);
            this.btnRemoverPaciente.TabIndex = 11;
            this.btnRemoverPaciente.Text = "Remover";
            this.btnRemoverPaciente.UseVisualStyleBackColor = true;
            this.btnRemoverPaciente.Click += new System.EventHandler(this.btnRemoverPaciente_Click);
            // 
            // lblEsportes
            // 
            this.lblEsportes.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblEsportes.AutoSize = true;
            this.lblEsportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEsportes.Location = new System.Drawing.Point(49, 79);
            this.lblEsportes.Name = "lblEsportes";
            this.lblEsportes.Size = new System.Drawing.Size(73, 32);
            this.lblEsportes.TabIndex = 12;
            this.lblEsportes.Text = "Esportes Praticados";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.50947F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.85279F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.51051F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.11011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.Controls.Add(this.btnCancelar, 7, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblConvenioChBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chbConvenio, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblConvenio, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumConvenio, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNomeConvenio, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumConvenio, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoSanguineo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtObjetivo, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoverPaciente, 8, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblEsportes, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 417);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.125F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.875F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1028, 316);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btBuscarRemocao
            // 
            this.btBuscarRemocao.Location = new System.Drawing.Point(575, 56);
            this.btBuscarRemocao.Name = "btBuscarRemocao";
            this.btBuscarRemocao.Size = new System.Drawing.Size(75, 23);
            this.btBuscarRemocao.TabIndex = 45;
            this.btBuscarRemocao.Text = "Buscar";
            this.btBuscarRemocao.UseVisualStyleBackColor = true;
            this.btBuscarRemocao.Click += new System.EventHandler(this.btBuscarRemocao_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(374, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(231, 13);
            this.label16.TabIndex = 44;
            this.label16.Text = "Digite o CPF do Paciente para remoção";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "CPF";
            // 
            // campoCPFRemocao
            // 
            this.campoCPFRemocao.Location = new System.Drawing.Point(373, 59);
            this.campoCPFRemocao.Name = "campoCPFRemocao";
            this.campoCPFRemocao.Size = new System.Drawing.Size(135, 20);
            this.campoCPFRemocao.TabIndex = 42;
            this.campoCPFRemocao.TextChanged += new System.EventHandler(this.campoIDRemocao_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.btBuscarRemocao);
            this.groupBox1.Controls.Add(this.campoCPFRemocao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1028, 111);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // ucEndereco1
            // 
            this.ucEndereco1.AutoSize = true;
            this.ucEndereco1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucEndereco1.Location = new System.Drawing.Point(0, 256);
            this.ucEndereco1.Name = "ucEndereco1";
            this.ucEndereco1.Size = new System.Drawing.Size(1234, 143);
            this.ucEndereco1.TabIndex = 4;
            // 
            // ucPessoa1
            // 
            this.ucPessoa1.AutoSize = true;
            this.ucPessoa1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPessoa1.Location = new System.Drawing.Point(0, 110);
            this.ucPessoa1.Name = "ucPessoa1";
            this.ucPessoa1.Size = new System.Drawing.Size(1240, 140);
            this.ucPessoa1.TabIndex = 3;
            this.ucPessoa1.Load += new System.EventHandler(this.ucPessoa1_Load);
            // 
            // removerPacienteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 733);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ucEndereco1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ucPessoa1);
            this.Name = "removerPacienteView";
            this.Text = "Remover Paciente - Secretária";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ucEndereco ucEndereco1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblConvenioChBox;
        private System.Windows.Forms.CheckBox chbConvenio;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label lblNumConvenio;
        private System.Windows.Forms.TextBox txtNomeConvenio;
        private System.Windows.Forms.TextBox txtNumConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTipoSanguineo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtObjetivo;
        private System.Windows.Forms.Button btnRemoverPaciente;
        private System.Windows.Forms.Label lblEsportes;
        private UserControls.ucPessoa ucPessoa1;
        private System.Windows.Forms.Button btBuscarRemocao;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox campoCPFRemocao;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}