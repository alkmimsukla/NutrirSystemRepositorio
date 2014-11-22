namespace View.PagamentosView
{
    partial class RegistrarPagamentoView
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
            this.labelPaciente = new System.Windows.Forms.Label();
            this.comboboxPaciente = new System.Windows.Forms.ComboBox();
            this.comboboxConsulta = new System.Windows.Forms.ComboBox();
            this.labelConsulta = new System.Windows.Forms.Label();
            this.labelValorConsulta = new System.Windows.Forms.Label();
            this.textBoxvalorConsulta = new System.Windows.Forms.TextBox();
            this.labelTipoPgt = new System.Windows.Forms.Label();
            this.radioButtonCartao = new System.Windows.Forms.RadioButton();
            this.radioButtonDinheiro = new System.Windows.Forms.RadioButton();
            this.labelValorParcelaExibicao = new System.Windows.Forms.Label();
            this.labelValorParcelas = new System.Windows.Forms.Label();
            this.textBoxNumParcelas = new System.Windows.Forms.TextBox();
            this.labelNumParcelas = new System.Windows.Forms.Label();
            this.textBoxNomeTitular = new System.Windows.Forms.TextBox();
            this.labelTitular = new System.Windows.Forms.Label();
            this.textBoxBandeira = new System.Windows.Forms.TextBox();
            this.labelBandeira = new System.Windows.Forms.Label();
            this.btRegistrarPgt = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.groupBoxCartao = new System.Windows.Forms.GroupBox();
            this.groupBoxCartao.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPaciente
            // 
            this.labelPaciente.AutoSize = true;
            this.labelPaciente.Location = new System.Drawing.Point(49, 29);
            this.labelPaciente.Name = "labelPaciente";
            this.labelPaciente.Size = new System.Drawing.Size(49, 13);
            this.labelPaciente.TabIndex = 0;
            this.labelPaciente.Text = "Paciente";
            this.labelPaciente.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboboxPaciente
            // 
            this.comboboxPaciente.FormattingEnabled = true;
            this.comboboxPaciente.Location = new System.Drawing.Point(165, 29);
            this.comboboxPaciente.Name = "comboboxPaciente";
            this.comboboxPaciente.Size = new System.Drawing.Size(121, 21);
            this.comboboxPaciente.TabIndex = 1;
            this.comboboxPaciente.SelectionChangeCommitted += new System.EventHandler(this.comboboxPaciente_SelectionChangeCommitted);
            // 
            // comboboxConsulta
            // 
            this.comboboxConsulta.FormattingEnabled = true;
            this.comboboxConsulta.Location = new System.Drawing.Point(165, 68);
            this.comboboxConsulta.Name = "comboboxConsulta";
            this.comboboxConsulta.Size = new System.Drawing.Size(121, 21);
            this.comboboxConsulta.TabIndex = 3;
            // 
            // labelConsulta
            // 
            this.labelConsulta.AutoSize = true;
            this.labelConsulta.Location = new System.Drawing.Point(49, 68);
            this.labelConsulta.Name = "labelConsulta";
            this.labelConsulta.Size = new System.Drawing.Size(107, 13);
            this.labelConsulta.TabIndex = 2;
            this.labelConsulta.Text = "Selecione a Consulta";
            // 
            // labelValorConsulta
            // 
            this.labelValorConsulta.AutoSize = true;
            this.labelValorConsulta.Location = new System.Drawing.Point(49, 108);
            this.labelValorConsulta.Name = "labelValorConsulta";
            this.labelValorConsulta.Size = new System.Drawing.Size(75, 13);
            this.labelValorConsulta.TabIndex = 4;
            this.labelValorConsulta.Text = "Valor Consulta";
            // 
            // textBoxvalorConsulta
            // 
            this.textBoxvalorConsulta.Location = new System.Drawing.Point(165, 108);
            this.textBoxvalorConsulta.Name = "textBoxvalorConsulta";
            this.textBoxvalorConsulta.Size = new System.Drawing.Size(100, 20);
            this.textBoxvalorConsulta.TabIndex = 5;
            this.textBoxvalorConsulta.TextChanged += new System.EventHandler(this.textBoxvalorConsulta_TextChanged);
            // 
            // labelTipoPgt
            // 
            this.labelTipoPgt.AutoSize = true;
            this.labelTipoPgt.Location = new System.Drawing.Point(49, 154);
            this.labelTipoPgt.Name = "labelTipoPgt";
            this.labelTipoPgt.Size = new System.Drawing.Size(31, 13);
            this.labelTipoPgt.TabIndex = 6;
            this.labelTipoPgt.Text = "Tipo ";
            // 
            // radioButtonCartao
            // 
            this.radioButtonCartao.AutoSize = true;
            this.radioButtonCartao.Location = new System.Drawing.Point(126, 163);
            this.radioButtonCartao.Name = "radioButtonCartao";
            this.radioButtonCartao.Size = new System.Drawing.Size(56, 17);
            this.radioButtonCartao.TabIndex = 7;
            this.radioButtonCartao.TabStop = true;
            this.radioButtonCartao.Text = "Cartão";
            this.radioButtonCartao.UseVisualStyleBackColor = true;
            this.radioButtonCartao.CheckedChanged += new System.EventHandler(this.radioButtonCartao_CheckedChanged);
            // 
            // radioButtonDinheiro
            // 
            this.radioButtonDinheiro.AutoSize = true;
            this.radioButtonDinheiro.Location = new System.Drawing.Point(230, 163);
            this.radioButtonDinheiro.Name = "radioButtonDinheiro";
            this.radioButtonDinheiro.Size = new System.Drawing.Size(64, 17);
            this.radioButtonDinheiro.TabIndex = 8;
            this.radioButtonDinheiro.TabStop = true;
            this.radioButtonDinheiro.Text = "Dinheiro";
            this.radioButtonDinheiro.UseVisualStyleBackColor = true;
            this.radioButtonDinheiro.CheckedChanged += new System.EventHandler(this.radioButtonDinheiro_CheckedChanged);
            // 
            // labelValorParcelaExibicao
            // 
            this.labelValorParcelaExibicao.AutoSize = true;
            this.labelValorParcelaExibicao.Location = new System.Drawing.Point(119, 162);
            this.labelValorParcelaExibicao.Name = "labelValorParcelaExibicao";
            this.labelValorParcelaExibicao.Size = new System.Drawing.Size(43, 13);
            this.labelValorParcelaExibicao.TabIndex = 7;
            this.labelValorParcelaExibicao.Text = "VALOR";
            // 
            // labelValorParcelas
            // 
            this.labelValorParcelas.AutoSize = true;
            this.labelValorParcelas.Location = new System.Drawing.Point(27, 162);
            this.labelValorParcelas.Name = "labelValorParcelas";
            this.labelValorParcelas.Size = new System.Drawing.Size(85, 13);
            this.labelValorParcelas.TabIndex = 6;
            this.labelValorParcelas.Text = "Valor da Parcela";
            // 
            // textBoxNumParcelas
            // 
            this.textBoxNumParcelas.Location = new System.Drawing.Point(122, 122);
            this.textBoxNumParcelas.Name = "textBoxNumParcelas";
            this.textBoxNumParcelas.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumParcelas.TabIndex = 5;
            this.textBoxNumParcelas.TextChanged += new System.EventHandler(this.textBoxNumParcelas_TextChanged);
            // 
            // labelNumParcelas
            // 
            this.labelNumParcelas.AutoSize = true;
            this.labelNumParcelas.Location = new System.Drawing.Point(27, 122);
            this.labelNumParcelas.Name = "labelNumParcelas";
            this.labelNumParcelas.Size = new System.Drawing.Size(63, 13);
            this.labelNumParcelas.TabIndex = 4;
            this.labelNumParcelas.Text = "Nº Parcelas";
            // 
            // textBoxNomeTitular
            // 
            this.textBoxNomeTitular.Location = new System.Drawing.Point(122, 87);
            this.textBoxNomeTitular.Name = "textBoxNomeTitular";
            this.textBoxNomeTitular.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomeTitular.TabIndex = 3;
            // 
            // labelTitular
            // 
            this.labelTitular.AutoSize = true;
            this.labelTitular.Location = new System.Drawing.Point(27, 87);
            this.labelTitular.Name = "labelTitular";
            this.labelTitular.Size = new System.Drawing.Size(67, 13);
            this.labelTitular.TabIndex = 2;
            this.labelTitular.Text = "Nome Titular";
            // 
            // textBoxBandeira
            // 
            this.textBoxBandeira.Location = new System.Drawing.Point(122, 48);
            this.textBoxBandeira.Name = "textBoxBandeira";
            this.textBoxBandeira.Size = new System.Drawing.Size(100, 20);
            this.textBoxBandeira.TabIndex = 1;
            this.textBoxBandeira.TextChanged += new System.EventHandler(this.textBoxBandeira_TextChanged);
            // 
            // labelBandeira
            // 
            this.labelBandeira.AutoSize = true;
            this.labelBandeira.Location = new System.Drawing.Point(27, 48);
            this.labelBandeira.Name = "labelBandeira";
            this.labelBandeira.Size = new System.Drawing.Size(49, 13);
            this.labelBandeira.TabIndex = 0;
            this.labelBandeira.Text = "Bandeira";
            // 
            // btRegistrarPgt
            // 
            this.btRegistrarPgt.Location = new System.Drawing.Point(439, 366);
            this.btRegistrarPgt.Name = "btRegistrarPgt";
            this.btRegistrarPgt.Size = new System.Drawing.Size(81, 34);
            this.btRegistrarPgt.TabIndex = 10;
            this.btRegistrarPgt.Text = "Registrar";
            this.btRegistrarPgt.UseVisualStyleBackColor = true;
            this.btRegistrarPgt.Click += new System.EventHandler(this.btRegistrarPgt_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.Location = new System.Drawing.Point(579, 366);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(78, 34);
            this.btVoltar.TabIndex = 11;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = true;
            // 
            // groupBoxCartao
            // 
            this.groupBoxCartao.Controls.Add(this.labelValorParcelaExibicao);
            this.groupBoxCartao.Controls.Add(this.labelTitular);
            this.groupBoxCartao.Controls.Add(this.labelValorParcelas);
            this.groupBoxCartao.Controls.Add(this.labelBandeira);
            this.groupBoxCartao.Controls.Add(this.textBoxNumParcelas);
            this.groupBoxCartao.Controls.Add(this.textBoxBandeira);
            this.groupBoxCartao.Controls.Add(this.labelNumParcelas);
            this.groupBoxCartao.Controls.Add(this.textBoxNomeTitular);
            this.groupBoxCartao.Location = new System.Drawing.Point(40, 214);
            this.groupBoxCartao.Name = "groupBoxCartao";
            this.groupBoxCartao.Size = new System.Drawing.Size(316, 201);
            this.groupBoxCartao.TabIndex = 12;
            this.groupBoxCartao.TabStop = false;
            this.groupBoxCartao.Text = "Dados do Cartão";
            // 
            // RegistrarPagamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 445);
            this.Controls.Add(this.groupBoxCartao);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btRegistrarPgt);
            this.Controls.Add(this.radioButtonDinheiro);
            this.Controls.Add(this.radioButtonCartao);
            this.Controls.Add(this.labelTipoPgt);
            this.Controls.Add(this.textBoxvalorConsulta);
            this.Controls.Add(this.labelValorConsulta);
            this.Controls.Add(this.comboboxConsulta);
            this.Controls.Add(this.labelConsulta);
            this.Controls.Add(this.comboboxPaciente);
            this.Controls.Add(this.labelPaciente);
            this.Name = "RegistrarPagamentoView";
            this.Text = "Registrar Pagamento";
            this.Load += new System.EventHandler(this.RegistrarPagamentoView_Load);
            this.groupBoxCartao.ResumeLayout(false);
            this.groupBoxCartao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPaciente;
        private System.Windows.Forms.ComboBox comboboxPaciente;
        private System.Windows.Forms.ComboBox comboboxConsulta;
        private System.Windows.Forms.Label labelConsulta;
        private System.Windows.Forms.Label labelValorConsulta;
        private System.Windows.Forms.TextBox textBoxvalorConsulta;
        private System.Windows.Forms.Label labelTipoPgt;
        private System.Windows.Forms.RadioButton radioButtonCartao;
        private System.Windows.Forms.RadioButton radioButtonDinheiro;
        private System.Windows.Forms.Label labelValorParcelaExibicao;
        private System.Windows.Forms.Label labelValorParcelas;
        private System.Windows.Forms.TextBox textBoxNumParcelas;
        private System.Windows.Forms.Label labelNumParcelas;
        private System.Windows.Forms.TextBox textBoxNomeTitular;
        private System.Windows.Forms.Label labelTitular;
        private System.Windows.Forms.TextBox textBoxBandeira;
        private System.Windows.Forms.Label labelBandeira;
        private System.Windows.Forms.Button btRegistrarPgt;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.GroupBox groupBoxCartao;
    }
}