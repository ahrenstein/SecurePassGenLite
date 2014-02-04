// ----------------------------------------------------------------------
// <copyright file="frmMain.cs" company="Ahrenstein">
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
 * $created guid: 4282c961-89d1-46ef-8acc-3c4b16ac83fc 2014/1/31$
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SecurePassGenLite.Common;

namespace SecurePassword.GeneratorLite
{
    /// <summary>
    /// Implements the logic for the main application form.
    /// </summary>
    public partial class frmMain : Form
    {
        /**
         * Methods
         */
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event that occurs when the "Quit" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Event that occurs when the "Generate Password" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenPass_Click(object sender, EventArgs e)
        {
            PassGenFunctions genpass = new PassGenFunctions();
            txtPassword.Text = genpass.GeneratePassword(txtSeed.Text, txtFQDN.Text);
        }

        /// <summary>
        /// Event that occurs when the "Clear" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFQDN.Clear();
            txtSeed.Clear();
            txtPassword.Clear();
        }

        /// <summary>
        /// Event that occurs when the "About" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout aboutBox = new frmAbout();
            aboutBox.ShowDialog();
        }
    } // public partial class frmMain : Form
} // namespace SecurePassword.GeneratorLite
