using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Configuration;
using System.Web.Security;

namespace FastTravel.Intranet.Utilites
{
    /// <summary>
    /// Password manager
    /// </summary>
    public class PasswordHelper
    {
        private const string CONFIG_KEY_PWD = "HashPasswords";
        private const string HASH_ALGORITHM_FOR_PASSWORDS = "SHA1";
        private const int SALT_LENGTH = 16;

        /// <summary>
        /// Password hash
        /// </summary>
        /// <param name="password">Password</param>
        /// <param name="passwordSalt">Key</param>
        /// <returns></returns>
        public static string HashPassword(string password, string passwordSalt)
        {
            bool useHash = false;
            try
            {
                useHash = bool.Parse(WebConfigurationManager.AppSettings.Get(CONFIG_KEY_PWD));
            }
            catch (SystemException)
            {
            }
            return useHash
                       ? FormsAuthentication.HashPasswordForStoringInConfigFile(passwordSalt + password,
                                                                                HASH_ALGORITHM_FOR_PASSWORDS)
                       : password.PadRight(40);
        }

        /// <summary>
        /// Key generator
        /// </summary>
        /// <returns>Key</returns>
        public static string GeneratePasswordSalt()
        {
            var rng = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_LENGTH];
            rng.GetBytes(salt);

            return Convert.ToBase64String(salt);
        }
    }
}