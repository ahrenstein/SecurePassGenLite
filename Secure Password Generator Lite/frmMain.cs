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

namespace Secure_Password_Generator_Lite
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            PassGenFunctionsL genpass = new PassGenFunctionsL();
            txtPassword.Text = genpass.GeneratePassword(txtSeed.Text, txtFQDN.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFQDN.Clear();
            txtSeed.Clear();
            txtPassword.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAbout aboutBox = new frmAbout();
            aboutBox.ShowDialog();
        }
    }
}
