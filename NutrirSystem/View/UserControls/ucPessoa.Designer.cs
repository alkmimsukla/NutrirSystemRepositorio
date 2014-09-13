namespace View.UserControls
{
    partial class ucPessoa
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbPessoa = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtmDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.lblApelido = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mkdCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mkdTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mkdCelular = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.gpbPessoa.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbPessoa
            // 
            this.gpbPessoa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbPessoa.AutoSize = true;
            this.gpbPessoa.Controls.Add(this.tableLayoutPanel1);
            this.gpbPessoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPessoa.Location = new System.Drawing.Point(4, 4);
            this.gpbPessoa.Name = "gpbPessoa";
            this.gpbPessoa.Size = new System.Drawing.Size(1193, 113);
            this.gpbPessoa.TabIndex = 0;
            this.gpbPessoa.TabStop = false;
            this.gpbPessoa.Text = "Dados Pessoais";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.80539F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.20472F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.71019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.68745F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.919124F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.58888F));
            this.tableLayoutPanel1.Controls.Add(this.dtmDataNascimento, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbSexo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblSexo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtApelido, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblApelido, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCPF, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mkdCPF, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNome, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mkdTelefone, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.mkdCelular, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 5, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1187, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dtmDataNascimento
            // 
            this.dtmDataNascimento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtmDataNascimento.Location = new System.Drawing.Point(427, 34);
            this.dtmDataNascimento.Name = "dtmDataNascimento";
            this.dtmDataNascimento.Size = new System.Drawing.Size(370, 22);
            this.dtmDataNascimento.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(290, 37);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(131, 16);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "Data de Nascimento";
            // 
            // cmbSexo
            // 
            this.cmbSexo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cmbSexo.Location = new System.Drawing.Point(155, 34);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(112, 24);
            this.cmbSexo.TabIndex = 4;
            this.cmbSexo.Leave += new System.EventHandler(this.cmbSexo_Leave);
            // 
            // lblSexo
            // 
            this.lblSexo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(110, 37);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 16);
            this.lblSexo.TabIndex = 17;
            this.lblSexo.Text = "Sexo";
            // 
            // txtApelido
            // 
            this.txtApelido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtApelido.Location = new System.Drawing.Point(909, 4);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(170, 22);
            this.txtApelido.TabIndex = 3;
            // 
            // lblApelido
            // 
            this.lblApelido.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApelido.AutoSize = true;
            this.lblApelido.Location = new System.Drawing.Point(848, 7);
            this.lblApelido.Name = "lblApelido";
            this.lblApelido.Size = new System.Drawing.Size(55, 16);
            this.lblApelido.TabIndex = 5;
            this.lblApelido.Text = "Apelido";
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(115, 7);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 16);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // mkdCPF
            // 
            this.mkdCPF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mkdCPF.Location = new System.Drawing.Point(155, 4);
            this.mkdCPF.Mask = "00000000000";
            this.mkdCPF.Name = "mkdCPF";
            this.mkdCPF.Size = new System.Drawing.Size(112, 22);
            this.mkdCPF.TabIndex = 1;
            this.mkdCPF.Leave += new System.EventHandler(this.mkdCPF_Leave);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(376, 7);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNome.Location = new System.Drawing.Point(427, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(370, 22);
            this.txtNome.TabIndex = 2;
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Telefone";
            // 
            // mkdTelefone
            // 
            this.mkdTelefone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mkdTelefone.Location = new System.Drawing.Point(155, 65);
            this.mkdTelefone.Mask = "(99) 0000-0000";
            this.mkdTelefone.Name = "mkdTelefone";
            this.mkdTelefone.Size = new System.Drawing.Size(112, 22);
            this.mkdTelefone.TabIndex = 7;
            this.mkdTelefone.Leave += new System.EventHandler(this.mkdTelefone_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Celular";
            // 
            // mkdCelular
            // 
            this.mkdCelular.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mkdCelular.Location = new System.Drawing.Point(427, 65);
            this.mkdCelular.Mask = "(99) 0000-0000";
            this.mkdCelular.Name = "mkdCelular";
            this.mkdCelular.Size = new System.Drawing.Size(106, 22);
            this.mkdCelular.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(857, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(909, 34);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(170, 22);
            this.txtEmail.TabIndex = 6;
            // 
            // ucPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.gpbPessoa);
            this.Name = "ucPessoa";
            this.Size = new System.Drawing.Size(1200, 120);
            this.gpbPessoa.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPessoa;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblApelido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.MaskedTextBox mkdCPF;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.DateTimePicker dtmDataNascimento;
        public System.Windows.Forms.ComboBox cmbSexo;
        public System.Windows.Forms.TextBox txtApelido;
        public System.Windows.Forms.MaskedTextBox mkdTelefone;
        public System.Windows.Forms.MaskedTextBox mkdCelular;
        public System.Windows.Forms.TextBox txtEmail;
    }
}
