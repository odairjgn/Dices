﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dices.Forms.Inputs;
using DicesCore;
using DicesCore.Contexto;
using DicesCore.Entidades;

namespace Dices.Forms
{
    public partial class frmPrincipal : Form
    {
        private Repositorio<Aventura> _aventuraRepositorio;

        private Aventura _aventura;

        public frmPrincipal(int idAventura)
        {
            InitializeComponent();
            _aventuraRepositorio = new Repositorio<Aventura>(Global.Contexto);
            _aventura = _aventuraRepositorio.Get(idAventura);
            mainMenu.Dock = DockStyle.Fill;
        }

        private void frmPrincipal_Load(object sender, System.EventArgs e)
        {
            Text = $"Dices: {_aventura.Titulo}";
        }


        private void calc_Click(object sender, System.EventArgs e)
        {
            if (Application.OpenForms.Cast<Form>().Any(f => f is frmCalc))
            {
                var form = Application.OpenForms.Cast<Form>().First(f => f is frmCalc);
                form.Focus();
                return;
            }

            new frmCalc().Show();
        }
    }
}
