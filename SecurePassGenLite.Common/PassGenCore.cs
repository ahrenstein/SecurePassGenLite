// ----------------------------------------------------------------------
// <copyright file="PassGenCore.cs" company="Ahrenstein">
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
 * $created guid: f9445c4d-cf70-4f02-a529-50f7bfde2143 2014/1/31$
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SecurePassGenLite.Common
{
    /// <summary>
    /// Implements core password generation logic.
    /// </summary>
    internal class PassGenCore
    {
        #region CorePasswordFunctions
        /// <summary>
        /// Generate a compliant password based on U.S. Government standard requirements
        /// </summary>
        /// <param name="sSeed">Unique seed value</param>
        /// <param name="sFQDN">Fully Qualified Domain Name of system to generate password for</param>
        /// <param name="iMaxLength">Max length of password</param>
        /// <returns>Returns a compliant password</returns>
        public string GenPass(string sSeed, string sFQDN, int iMaxLength)
        {
            string newseed = sSeed + sFQDN; // creating an easier to use seed by combining Seed and FQDN
            int iSeed = 0;
            
            // generate an integer seed value by adding the ASCII values of the seed characters
            foreach (char ch in newseed.ToCharArray()) 
                iSeed += ch;

            Random rnd = new Random(iSeed);
            string sPassword = "";
            string sCharactersNotAllowed = ","; // these characters should be skipped when generating passwords
            bool hasUpperCase, hasLowerCase, hasNumber, hasSymbol;
            
            // sets initial bool values to determine if a character requirement has been met yet
            hasUpperCase = hasLowerCase = hasSymbol = hasNumber = false; 
            
            // generate characters using ASCII values 33 through 126 (valid password characters in most cases)
            while (sPassword.Length != iMaxLength) 
            {
                char ch = (char)rnd.Next(33, 126);
                // blocks the use of excluded characters
                if (sCharactersNotAllowed.IndexOf(ch) != -1) 
                    continue;

                // determines if we have used at least 1 upper case letter yet
                if (Char.IsUpper(ch) && !hasUpperCase) 
                {
                    sPassword += ch;
                    hasUpperCase = true;
                }
                else if (Char.IsLower(ch) && !hasLowerCase) // determines if we have used at least 1 lower case letter yet
                {
                    sPassword += ch;
                    hasLowerCase = true;
                }
                else if (sPassword.Length != 0 && sPassword.Length != iMaxLength - 1) // prevents the password from starting or ending in a number or symbol
                {
                    // determines if we have used at least 1 number yet
                    if (char.IsNumber(ch) && !hasNumber)
                    {
                        sPassword += ch;
                        hasNumber = true;
                    }
                    else if (Char.IsSymbol(ch) && !hasSymbol) // determines if we have used at least 1 symbol yet
                    {
                        sPassword += ch;
                        hasSymbol = true;
                    }
                }

                // forces the password to start, and end in a letter of any case
                if (sPassword.Length == iMaxLength - 1) 
                {
                    hasUpperCase = hasLowerCase = false;
                }
                if (hasUpperCase && hasLowerCase && hasSymbol && hasNumber)
                    hasUpperCase = hasLowerCase = hasSymbol = hasNumber = false;
            }
            return sPassword;
        }
        #endregion
    } // internal class PassGenCore
} // namespace SecurePassGenLite.Common
