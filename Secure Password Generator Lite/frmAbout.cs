// ----------------------------------------------------------------------
// <copyright file="frmAbout.cs" company="Ahrenstein">
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
 * $created guid: c4791d8e-6cb8-4dda-9a0e-210dc8f949ff 2014/1/31$
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection; // used for grabbing Assembly info to make a nice About Box

namespace SecurePassword.GeneratorLite
{
    /// <summary>
    /// Implements the logic code for the about box.
    /// </summary>
    public partial class frmAbout : Form
    {
        /**
         * Methods
         */
        /// <summary>
        /// Initializes a new instance of the <see cref="frmAbout"/> class.
        /// </summary>
        public frmAbout()
        {
            string[] projectDescription = new string[]
            {
                "Secure Password Generator Lite.",
                "This program was originally designed to generate Dept. of Energy",
                "compliant passwords but has since been modified to be open",
                "for all to use to create easy to manage but secure passwords.",
                "",
                "\t\t*** Secure Password Generator Lite Credits ***",
                "Matthew Ahrenstein:",
                "\t- Common Library (Contains Password Generating Formulas and Functions)",
                "\t- User Interface",
                "",
                "Nevec Networks LLC:",
                "\t- Assembly Attribute Accessors (Used to grab build/version info automatically)",
                "\t- Minor Code Cleanup",
                "\t- Added password length variability",
            };

            InitializeComponent();
            this.lblProjectName.Text = AssemblyVersion._NAME;
            this.lblVersion.Text = "Version: " + AssemblyVersion._VERSION_STRING;
            this.lblCopyright.Text = AssemblyVersion._COPYRIGHT;
            this.txtDescription.Lines = projectDescription;
        }

        /// <summary>
        /// Event that occurs when the "Close" button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    } // public partial class frmAbout : Form
} // namespace SecurePassword.GeneratorLite
