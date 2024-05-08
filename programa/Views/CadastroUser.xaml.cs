﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AppEdu.Views
{
    /// <summary>
    /// Lógica interna para CadastroUser.xaml
    /// </summary>
    public partial class CadastroUser : Window
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void AcessoCurso_Click(object sender, MouseButtonEventArgs a)
        {
            CadastroCurso cadastroCurso = new CadastroCurso();
            cadastroCurso.Show();
            this.Close();
        }

        private void AcessoTurma_Click(object sender, MouseButtonEventArgs i)
        {
            CadastroTurma cadastroTurma = new CadastroTurma();
            cadastroTurma.Show();
            this.Close();
        }

        private void AcessoEscola_Click(object sender, MouseButtonEventArgs e)
        {
            CadastroEscola cadastroEscola = new CadastroEscola();
            cadastroEscola.Show();
            this.Close();
        }

        private void AcessoConsultarEscola_Click(object sender, MouseButtonEventArgs e)
        {
            ConsultarEscola consultaEscola = new ConsultarEscola();
            consultaEscola.Show();
            this.Close();
        }

        private void AcessoConsultarTurma_Click(object sender, MouseButtonEventArgs e)
        {
            ConsultarTurma consultaTurma = new ConsultarTurma();
            consultaTurma.Show();
            this.Close();
        }

        private void AcessoConsultarCurso_Click(object sender, MouseButtonEventArgs e)
        {
            ConsultarCurso consultaCurso = new ConsultarCurso();
            consultaCurso.Show();
            this.Close();
        }
    }
}
