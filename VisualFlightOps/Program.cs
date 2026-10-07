using System;
using System.Windows.Forms;
/*!
 * Visual Flight Operations Management System
 * Copyright (c) 2026 Louie Bloomberg.
 * SPDX-License-Identifier: MIT
 */


namespace VisualFlightOps.Framework
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
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

