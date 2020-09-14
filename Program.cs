// <copyright file="Program.cs" company="Ashi Chamarasinghe">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/*
  Kadupitige Ashi Chamarasinghe
  011611751
 */
namespace Homework3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// This class contain main function for this program. It calls the form to output the program.
    /// </summary>
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
            Application.Run(new Form1());
        }
    }
}
