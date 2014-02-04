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
/**
 * Copyright (c) 2014 Nevec Networks LLC., All Rights Reserved.
 * INTERNAL/PROPRIETARY/CONFIDENTIAL. Use is subject to license terms.
 * DO NOT ALTER OR REMOVE COPYRIGHT NOTICES OR THIS FILE HEADER.
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
        public static string GeneratePassword(string seed, string fqdn, int passwordLength)
        {
            if (seed == string.Empty)
                return "ERROR! Seed field cannot be empty!";

            if (fqdn == string.Empty)
                return "ERROR! FQDN field cannot be empty!";

            if (passwordLength <= 8)
                passwordLength = 8; // default the password length to 8 if we get a value less then 8

            PassGenCore command = new PassGenCore();
            return command.GenPass(seed, fqdn, passwordLength);
        }
        #endregion
    } // public class PassGenFunctions
} // namespace SecurePassGenLite.Common
