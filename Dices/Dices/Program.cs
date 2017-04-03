﻿using System;
using System.Windows.Forms;
using Dices.Forms;
using Dices.Forms.Inputs;
using DicesCore.Contexto;

namespace Dices
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Contexto = new DicesContext();

            Application.Run(new frmSelAventura());
        }

        public static DicesCore.Contexto.DicesContext Contexto { get; set; }
    }
}
