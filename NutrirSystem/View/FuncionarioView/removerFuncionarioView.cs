﻿using NutrirSystem.Controller;
using NutrirSystem.Data;
using System;
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
    public partial class removerFuncionarioView : Form
    {
        CadFuncController funcionarioController;

        public removerFuncionarioView()
        {
            InitializeComponent();

            campoSexoRemocao.DataSource = Enum.GetValues(typeof(Sexo));
            campoPerfilRemocao.DataSource = Enum.GetValues(typeof(Perfil));

            // escondo campos CRN
            labelCRN.Hide();
            campoCRNRemocao.Hide();

            //escondo painel dos dados do funcionário buscado.
            panel1.Hide();

            funcionarioController = new CadFuncController();
        }

        private void btBuscarRemocao_Click(object sender, EventArgs e)
        {
            Funcionario funcionarioBuscado = funcionarioController.buscarFuncionario(decimal.Parse(campoCPFRemocao.Text.Trim()));

            if (funcionarioBuscado != null)
            {
                preencherCamposView(funcionarioBuscado);
            }

            else
            {
                exibirMsgFuncionarioInexistente();
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            bool funcionarioExistente = funcionarioController.VerificarDupCPF(decimal.Parse(campoCPFRemocao.Text.Trim()));

            if (funcionarioExistente)
            {
                funcionarioController.excluirFuncionario(decimal.Parse(campoCPFRemocao.Text.Trim()));
                exibirMsgExclusaoSucesso();
            }
        }

        private void campoCPFRemocao_TextChanged(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void validarFormatoCPF()
        {
            string cpfDigitado = campoCPFRemocao.Text;
            decimal convertido = 9760; // numero qualquer 
            decimal.TryParse(cpfDigitado, out convertido);

            if (convertido == 0)
            {
                exibirMsgCPFFormatoInvalido();
                campoCPFRemocao.Text = "";
            }
        }

        private void exibirMsgCPFFormatoInvalido()
        {
            MessageBox.Show("Campo CPF deve ser númerico! Tente novamente!");
        }

        private void exibirMsgFuncionarioInexistente()
        {
            MessageBox.Show("Funcionário Inexistente! Busque novamente!");
        }

        private void exibirMsgExclusaoSucesso()
        {
            MessageBox.Show("Funcionário excluído com Sucesso!");
        }

        private void preencherCamposView(Funcionario funcionarioBuscado)
        {
            campoNomeRemocao.Text = funcionarioBuscado.nome;
            campoApelidoRemocao.Text = funcionarioBuscado.apelido;
            campoSexoRemocao.SelectedItem = (Sexo)funcionarioBuscado.sexo;
            campoDtNascRemocao.Text = funcionarioBuscado.dataNascimento.ToShortDateString();
            campoSalarioRemocao.Text = funcionarioBuscado.salario.ToString();
            campoRuaRemocao.Text = funcionarioBuscado.rua;
            campoNumeroRemocao.Text = funcionarioBuscado.numero.ToString();
            campoBairroRemocao.Text = funcionarioBuscado.bairro;
            campoEmailRemocao.Text = funcionarioBuscado.email;
            campoTelefoneRemocao.Text = funcionarioBuscado.telefone;
            campoCelularRemocao.Text = funcionarioBuscado.celular;

            //Campos do Login
            campoUsuarioRemocao.Text = funcionarioBuscado.usuario;
            campoPerfilRemocao.SelectedItem = (Perfil)funcionarioBuscado.perfil;
            campoSenhaRemocao.Text = funcionarioBuscado.password;

            // mostrando panel1
            panel1.Show();

            bloquearCamposTela();
        }

        private void btVoltarRemocaoView_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bloquearCamposTela()
        {
            campoNomeRemocao.ReadOnly = true;
            campoApelidoRemocao.ReadOnly = true;
            campoSexoRemocao.Enabled = false;
            campoDtNascRemocao.ReadOnly = true;
            campoSalarioRemocao.ReadOnly = true;
            campoRuaRemocao.ReadOnly = true;
            campoNumeroRemocao.ReadOnly = true;
            campoBairroRemocao.ReadOnly = true;
            campoEmailRemocao.ReadOnly = true;
            campoTelefoneRemocao.ReadOnly = true;
            campoCelularRemocao.ReadOnly = true;

            //Campos do Login
            campoUsuarioRemocao.ReadOnly = true;
            campoPerfilRemocao.Enabled = false;
            campoSenhaRemocao.ReadOnly = true;
        }

        private void campoCPFRemocao_KeyUp(object sender, KeyEventArgs e)
        {
            validarFormatoCPF();
        }
    }
}
