// ----------------------------------------------------------------------
// <copyright file="Program.cs" company="Ahrenstein">
//     Copyright (c) 2014 Ahrenstein., All Rights Reserved.
//     Authors:
//          Matthew Ahrenstein 2014 @ahrenstein
// </copyright>
// ----------------------------------------------------------------------
/**
 * Secure Password Generator Lite
 * OPEN SOURCE PROJECT! Use is subject to license terms in LICENSE.txt
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 * 
 * $created guid: d9a8a8ec-4a87-4925-9308-14be9f001d30 2014/1/31$
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SecurePassword.GeneratorLite
{
    /// <summary>
    /// Program entry point.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    } // public static class Program
} // namespace SecurePassword.GeneratorLite
