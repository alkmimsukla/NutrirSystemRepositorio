﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class SecretariaView : Form
    {
        public SecretariaView()
        {
            InitializeComponent();
        }

        private void btnCadPaciente_Click(object sender, EventArgs e)
        {
            new formCadPac().Show();
        }
    }
}
