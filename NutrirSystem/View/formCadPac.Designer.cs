namespace View
{
    partial class formCadPac
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
            this.ucPessoa1 = new View.UserControls.ucPessoa();
            this.ucEndereco1 = new View.UserControls.ucEndereco();
            this.SuspendLayout();
            // 
            // ucPessoa1
            // 
            this.ucPessoa1.AutoSize = true;
            this.ucPessoa1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucPessoa1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucPessoa1.Location = new System.Drawing.Point(0, 0);
            this.ucPessoa1.Name = "ucPessoa1";
            this.ucPessoa1.Size = new System.Drawing.Size(1077, 154);
            this.ucPessoa1.TabIndex = 0;
            // 
            // ucEndereco1
            // 
            this.ucEndereco1.AutoSize = true;
            this.ucEndereco1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucEndereco1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucEndereco1.Location = new System.Drawing.Point(0, 154);
            this.ucEndereco1.Name = "ucEndereco1";
            this.ucEndereco1.Size = new System.Drawing.Size(1077, 154);
            this.ucEndereco1.TabIndex = 1;
            // 
            // formCadPac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 454);
            this.Controls.Add(this.ucEndereco1);
            this.Controls.Add(this.ucPessoa1);
            this.Name = "formCadPac";
            this.Text = "Cadastrar Paciente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.ucPessoa ucPessoa1;
        private UserControls.ucEndereco ucEndereco1;


    }
}