namespace View.Relatorios
{
    partial class formRelatorioClientes
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
            this.cbNutri = new System.Windows.Forms.ComboBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.fxetariaMin = new System.Windows.Forms.NumericUpDown();
            this.fxetariaMax = new System.Windows.Forms.NumericUpDown();
            this.cbConvenio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gradRel = new System.Windows.Forms.DataGridView();
            this.chbNutri = new System.Windows.Forms.CheckBox();
            this.chbGen = new System.Windows.Forms.CheckBox();
            this.chbIdade = new System.Windows.Forms.CheckBox();
            this.chbConv = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fxetariaMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxetariaMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradRel)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNutri
            // 
            this.cbNutri.FormattingEnabled = true;
            this.cbNutri.Location = new System.Drawing.Point(29, 45);
            this.cbNutri.Name = "cbNutri";
            this.cbNutri.Size = new System.Drawing.Size(146, 21);
            this.cbNutri.TabIndex = 0;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Location = new System.Drawing.Point(29, 112);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(146, 21);
            this.cbSexo.TabIndex = 1;
            // 
            // fxetariaMin
            // 
            this.fxetariaMin.Location = new System.Drawing.Point(29, 186);
            this.fxetariaMin.Name = "fxetariaMin";
            this.fxetariaMin.Size = new System.Drawing.Size(60, 20);
            this.fxetariaMin.TabIndex = 2;
            // 
            // fxetariaMax
            // 
            this.fxetariaMax.Location = new System.Drawing.Point(121, 186);
            this.fxetariaMax.Name = "fxetariaMax";
            this.fxetariaMax.Size = new System.Drawing.Size(54, 20);
            this.fxetariaMax.TabIndex = 3;
            // 
            // cbConvenio
            // 
            this.cbConvenio.FormattingEnabled = true;
            this.cbConvenio.Location = new System.Drawing.Point(29, 245);
            this.cbConvenio.Name = "cbConvenio";
            this.cbConvenio.Size = new System.Drawing.Size(146, 21);
            this.cbConvenio.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Consultado com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IntervaloFaixa Etária";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "até";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Convenio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Configure o filtro para gerar o relatório";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gradRel
            // 
            this.gradRel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gradRel.Location = new System.Drawing.Point(209, 47);
            this.gradRel.Name = "gradRel";
            this.gradRel.Size = new System.Drawing.Size(606, 263);
            this.gradRel.TabIndex = 13;
            // 
            // chbNutri
            // 
            this.chbNutri.AutoSize = true;
            this.chbNutri.Location = new System.Drawing.Point(29, 70);
            this.chbNutri.Name = "chbNutri";
            this.chbNutri.Size = new System.Drawing.Size(131, 17);
            this.chbNutri.TabIndex = 14;
            this.chbNutri.Text = "Todas as Nutricionista";
            this.chbNutri.UseVisualStyleBackColor = true;
            this.chbNutri.CheckedChanged += new System.EventHandler(this.chbNutri_CheckedChanged);
            // 
            // chbGen
            // 
            this.chbGen.AutoSize = true;
            this.chbGen.Location = new System.Drawing.Point(29, 139);
            this.chbGen.Name = "chbGen";
            this.chbGen.Size = new System.Drawing.Size(113, 17);
            this.chbGen.TabIndex = 15;
            this.chbGen.Text = "Todos os Generos";
            this.chbGen.UseVisualStyleBackColor = true;
            this.chbGen.CheckedChanged += new System.EventHandler(this.chbNutri_CheckedChanged);
            // 
            // chbIdade
            // 
            this.chbIdade.AutoSize = true;
            this.chbIdade.Location = new System.Drawing.Point(29, 211);
            this.chbIdade.Name = "chbIdade";
            this.chbIdade.Size = new System.Drawing.Size(105, 17);
            this.chbIdade.TabIndex = 16;
            this.chbIdade.Text = "Todas as Idades";
            this.chbIdade.UseVisualStyleBackColor = true;
            this.chbIdade.CheckedChanged += new System.EventHandler(this.chbNutri_CheckedChanged);
            // 
            // chbConv
            // 
            this.chbConv.AutoSize = true;
            this.chbConv.Location = new System.Drawing.Point(29, 272);
            this.chbConv.Name = "chbConv";
            this.chbConv.Size = new System.Drawing.Size(123, 17);
            this.chbConv.TabIndex = 17;
            this.chbConv.Text = "Todos os Convenios";
            this.chbConv.UseVisualStyleBackColor = true;
            this.chbConv.CheckedChanged += new System.EventHandler(this.chbNutri_CheckedChanged);
            // 
            // formRelatorioClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 351);
            this.Controls.Add(this.chbConv);
            this.Controls.Add(this.chbIdade);
            this.Controls.Add(this.chbGen);
            this.Controls.Add(this.chbNutri);
            this.Controls.Add(this.gradRel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbConvenio);
            this.Controls.Add(this.fxetariaMax);
            this.Controls.Add(this.fxetariaMin);
            this.Controls.Add(this.cbSexo);
            this.Controls.Add(this.cbNutri);
            this.Name = "formRelatorioClientes";
            this.Text = "Relatório Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.fxetariaMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fxetariaMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradRel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNutri;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.NumericUpDown fxetariaMin;
        private System.Windows.Forms.NumericUpDown fxetariaMax;
        private System.Windows.Forms.ComboBox cbConvenio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView gradRel;
        private System.Windows.Forms.CheckBox chbNutri;
        private System.Windows.Forms.CheckBox chbGen;
        private System.Windows.Forms.CheckBox chbIdade;
        private System.Windows.Forms.CheckBox chbConv;
    }
}