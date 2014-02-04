// ----------------------------------------------------------------------
// <copyright file="PassGenFunctions.cs" company="Ahrenstein">
//     Copyright (c) 2014 Ahrenstein., All Rights Reserved.
//     Authors:
//          Matthew Ahrenstein 2014 @ahrenstein
// </copyright>
// ----------------------------------------------------------------------
/**
 * SecurePassGenLite.Common
 * OPEN SOURCE PROJECT! Use is subject to license terms in LICENSE.txt
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
 * 
 * $created guid: e25663f7-dd73-4162-a765-de189de1f961 2014/1/31$
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurePassGenLite.Common
{
    /// <summary>
    /// Implements public accessor functions for generating passwords.
    /// </summary>
    public class PassGenFunctions
    {
        #region PasswordFunctions
        /// <summary>
        /// Generates the password using some built in values
        /// </summary>
        /// <param name="seed">Seed value agreed upon by client</param>
        /// <param name="fqdn">Fully Qualified Domain Name of system to generate password for</param>
        /// <returns>Returns a password to be used for protecting client systems</returns>
        public string GeneratePassword(string seed, string fqdn)
        {
            string generatedPassword = ""; // the generated password to be returned
            int errorCheck = 0; // sets up for error checking

            if (seed == "")
            {
                generatedPassword = "ERROR! Seed field cannot be NULL!";
                errorCheck++;
            }

            if (fqdn == "")
            {
                generatedPassword = "ERROR! FQDN field cannot be NULL!";
                errorCheck++;
            }
            if (errorCheck == 0)
            {
                int passwordLength = 9; // sets the password length to be used for all passwords
                PassGenCore command = new PassGenCore();
                generatedPassword = command.GenPass(seed, fqdn, passwordLength);
            }
            else if (errorCheck == 2)
            {
                generatedPassword = "ERROR! Seed & FQDN fields cannot be NULL!";
            }
            return generatedPassword;
        }
        #endregion
    } // public class PassGenFunctions
} // namespace SecurePassGenLite.Common
