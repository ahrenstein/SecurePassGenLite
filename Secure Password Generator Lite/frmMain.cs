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
/**
 * Copyright (c) 2014 Nevec Networks LLC., All Rights Reserved.
 * INTERNAL/PROPRIETARY/CONFIDENTIAL. Use is subject to license terms.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
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
         * Fields
         */
        private bool passwordLengthValueFail = false;

        /**
         * Methods
         */
        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();

            this.txtFQDN.KeyPress += txtFQDN_KeyPress;
            this.txtSeed.KeyPress += txtSeed_KeyPress;
            this.txtPasswordLength.KeyPress += txtPasswordLength_KeyPress;
            this.btnGenPass.Enabled = false;
        }

        /// <summary>
        /// Event that occurs when typing in the seed text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtSeed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSeed.Text != string.Empty && txtFQDN.Text != string.Empty && !passwordLengthValueFail)
                btnGenPass.Enabled = true;
        }

        /// <summary>
        /// Event that occurs when typing in the FQDN text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtFQDN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtSeed.Text != string.Empty && txtFQDN.Text != string.Empty && !passwordLengthValueFail)
                btnGenPass.Enabled = true;
        }

        /// <summary>
        /// Event that occurs when typing in the password length text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txtPasswordLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if the input value is not a digit throw message
            if (!char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Password length must be a numerical value!", AssemblyVersion._NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                btnGenPass.Enabled = false;
                txtPasswordLength.BackColor = Color.LightSalmon;
                passwordLengthValueFail = true;
            }

            // if the input value is a digit enable the generate button and reset background color
            if (char.IsDigit(e.KeyChar))
            {
                if (txtSeed.Text != string.Empty && txtFQDN.Text != string.Empty)
                    btnGenPass.Enabled = true;

                txtPasswordLength.BackColor = Color.White;
                passwordLengthValueFail = false;
            }
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
            int passwordLength = Convert.ToInt32(txtPasswordLength.Text);
            txtPassword.Text = PassGenFunctions.GeneratePassword(txtSeed.Text, txtFQDN.Text, passwordLength);
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

            txtPasswordLength.Text = "8";
            txtPasswordLength.BackColor = Color.White;

            btnGenPass.Enabled = false;
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
