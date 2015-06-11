using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace LeagueManagement_DX
{
    class Encryption
    {
        //byte[] KeyArray;
        //byte[] toEncryptArray;
        //public Encryption()
        //{
        //    this.KeyArray = null;
        //    this.toEncryptArray = null;
        //}
        //public string Encrypt(string stringToEncrypt, bool useHashing)
        //{
        //    this.toEncryptArray = Encoding.UTF8.GetBytes(stringToEncrypt);
        //    if (useHashing)
        //    {
        //        var hashMD5 = new MD5CryptoServiceProvider();
        //        this.KeyArray = hashMD5.ComputeHash(Encoding.UTF8.GetBytes(stringToEncrypt));
        //    }
        //    else
        //    {
        //        this.KeyArray = Encoding.UTF8.GetBytes(stringToEncrypt);
        //    }
        //    var tdes = new TripleDESCryptoServiceProvider {Key= this.KeyArray, Mode= CipherMode.ECB, Padding = PaddingMode.PKCS7 };
        //    ICryptoTransform cTransform = tdes.CreateEncryptor();
        //    byte[] result = cTransform.TransformFinalBlock(this.toEncryptArray, 0, toEncryptArray.Length);
        //    return Convert.ToBase64String(result);
        //}
        //public string Decrypt(string stringToDecrypt, bool useHashing)
        //{
        //    this.toEncryptArray = Convert.FromBase64String(stringToDecrypt);
        //    if (useHashing)
        //    {
        //        var hashMD5 = new MD5CryptoServiceProvider();
        //        this.KeyArray = hashMD5.ComputeHash(Encoding.UTF8.GetBytes(stringToDecrypt));
        //    }
        //    else
        //    {
        //        KeyArray = Encoding.UTF8.GetBytes(stringToDecrypt);
        //    }
        //    var tdes = new TripleDESCryptoServiceProvider { Key = this.KeyArray, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 };
        //    ICryptoTransform cTransform = tdes.CreateDecryptor();
        //    byte[] result = cTransform.TransformFinalBlock(this.toEncryptArray, 0, toEncryptArray.Length);
        //    return Encoding.UTF8.GetString(result);
        //}

        private string InputString;
        public string Password
        {
            get { return this.InputString; }
            set { InputString = value; }
        }
        public Encryption()
        {
 
        }
        public Encryption(string Input)
        {
            this.InputString = Input;
        }
        
        public string Encrypt()
        {
            byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(this.InputString);
            string result = Convert.ToBase64String(passBytes);
            return result;
        }

        public string Decrypt()
        {
            byte[] passByte = Convert.FromBase64String(this.InputString);
            string result = System.Text.Encoding.Unicode.GetString(passByte);
            return result;
        }
        //public string EncryptPassword(string PW)
        //{
        //    byte[] passBytes = System.Text.Encoding.Unicode.GetBytes(PW);
        //    string result = Convert.ToBase64String(passBytes);
        //    return result;
        //}
        //public string DecryptPassword(string PW)
        //{
        //    byte[] passByte = Convert.FromBase64String(PW);
        //    string result = System.Text.Encoding.Unicode.GetString(passByte);
        //    return result;
        //}
    }
}

