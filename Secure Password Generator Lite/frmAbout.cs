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
using System.Reflection; //Used for grabbing Assembly info to make a nice About Box

namespace Secure_Password_Generator_Lite
{
    public partial class frmAbout : Form
    {
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
                "-Common Library (Contains Password Generating Formulas and Functions)",
                "-User Interface",
                "",
                "Nevec Networks LLC:",
                "-Assembly Attribute Accessors (Used to grab build/version info automatically)"
            };

            InitializeComponent();
            this.lblProjectName.Text = "Project Name: " + AssemblyProduct;
            this.lblVersion.Text = "Build Version: " + AssemblyVersion;
            this.lblCopyright.Text = "Copyright: " + AssemblyCopyright;
            this.lblCompanyName.Text = "Company Name: " + AssemblyCompany;
            this.txtDescription.Lines = projectDescription;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion
    }
}
