using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace EVSoft.HRMSLicense
{
    public class Encryption
    {
        private byte[] signature;
		private string username, password;
		const int BIN_SIZE = 4096;
		private byte[] md5Key, md5IV;
		private bool validParameters;

        public Encryption(string username, string password)
		{
			this.username = username;
			this.password = password;
			if (username.Length + password.Length < 6)
			{
				validParameters = false;
				// abort the constructor. Calls to public functions will not work.
				return;
			}
			else
			{
				validParameters = true;
			}
			GenerateSignature();
			GenerateKey();
			GenerateIV();
		}

        #region Helper functions called from constructor only
        /// <summary>
        /// Generates a standard signature for the file. The signature may be longer than 16 bytes if deemed necessary.
        /// The signature, which is NOT ENCRYPTED, serves two purposes. 
        /// 1. It allows to recognize the file as one that has been encrypted with the XMLEncryptor class.
        /// 2. The first bytes of each XML file are quite similar (<?xml version="1.0" encoding="utf-8" ?>).
        ///	 This can be exploite to "guess" the key the file has been encrypted with. Adding a signature of a reasonably
        ///	 large number of bytes can be used to overcome this limitation.
        /// </summary>
        private void GenerateSignature()
        {
            signature = new byte[16] {
												 123,	078,	099,	166,
												 001,	043,	244,	008,
												 105,	089,	239,	255,
												 045,	188,	107,	033
											 };
        }
        /// <summary>
        /// Generates an MD5 key for encryption/decryption. This method is only called during construction.
        /// </summary>
        private void GenerateKey()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            StringBuilder hash = new StringBuilder(username + password);

            // Manipulate the hash string - not strictly necessary.
            for (int i = 1; i < hash.Length; i += 2)
            {
                char c = hash[i - 1];
                hash[i - 1] = hash[i];
                hash[i] = c;
            }

            // Convert the string into a byte array.
            Encoding unicode = Encoding.Unicode;
            byte[] unicodeBytes = unicode.GetBytes(hash.ToString());
            // Compute the key from the byte array
            md5Key = md5.ComputeHash(unicodeBytes);
        }
        /// <summary>
        /// Generates an MD5 Initiakization Vector for encryption/decryption. This method is only called during construction.
        /// </summary>
        private void GenerateIV()
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string hash = password + username;

            // Convert the string into a byte array.
            Encoding unicode = Encoding.Unicode;
            byte[] unicodeBytes = unicode.GetBytes(hash);

            // Compute the IV from the byte array
            md5IV = md5.ComputeHash(unicodeBytes);
        }


        #endregion

        #region Encrypt/Decrypt string

        public string Encrypt(string plainText)
        {
            // Convert our plaintext into a byte array.
            // Let us assume that plaintext contains UTF8-encoded characters.
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            RijndaelManaged symmetricKey = new RijndaelManaged();
            symmetricKey.Mode = CipherMode.CBC;
            ICryptoTransform encryptor = symmetricKey.CreateEncryptor(md5Key, md5IV);

            // Define memory stream which will be used to hold encrypted data.
            MemoryStream memoryStream = new MemoryStream();

            // Define cryptographic stream (always use Write mode for encryption).
            CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                         encryptor,
                                                         CryptoStreamMode.Write);
            // Start encrypting.
            cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);

            // Finish encrypting.
            cryptoStream.FlushFinalBlock();

            // Convert our encrypted data from a memory stream into a byte array.
            byte[] cipherTextBytes = memoryStream.ToArray();

            // Close both streams.
            memoryStream.Close();
            cryptoStream.Close();

            // Convert encrypted data into a base64-encoded string.
            string cipherText = Convert.ToBase64String(cipherTextBytes);

            // Return encrypted string.
            return cipherText;
        }

        public string Decrypt(string cipherText)
        {
            try
            {
                // Convert our ciphertext into a byte array.
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);

                // Create uninitialized Rijndael encryption object.
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(md5Key, md5IV);

                // Define memory stream which will be used to hold encrypted data.
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);

                // Define cryptographic stream (always use Read mode for encryption).
                CryptoStream cryptoStream = new CryptoStream(memoryStream,
                                                             decryptor,
                                                             CryptoStreamMode.Read);

                // Since at this point we don't know what the size of decrypted data
                // will be, allocate the buffer long enough to hold ciphertext;
                // plaintext is never longer than ciphertext.
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];

                // Start decrypting.
                int decryptedByteCount = cryptoStream.Read(plainTextBytes,
                                                           0,
                                                           plainTextBytes.Length);

                // Close both streams.
                memoryStream.Close();
                cryptoStream.Close();

                // Convert decrypted data into a string. 
                // Let us assume that the original plaintext string was UTF8-encoded.
                string plainText = Encoding.UTF8.GetString(plainTextBytes,
                                                           0,
                                                           decryptedByteCount);

                // Return decrypted string.   
                return plainText;
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        #endregion
    }
}
