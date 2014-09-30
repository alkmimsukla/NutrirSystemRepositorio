using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NutrirSystem.Controller;

namespace View.Relatorios
{
    public partial class formRelatorioClientes : Form
    {
        RelatorioController Controller_RelCli;

        public formRelatorioClientes()
        {
            InitializeComponent();

            Controller_RelCli  = new RelatorioController();

            Controller_RelCli.EmitirReCli(1235456, 1, "10-25", 2255);
        }
    }
}
