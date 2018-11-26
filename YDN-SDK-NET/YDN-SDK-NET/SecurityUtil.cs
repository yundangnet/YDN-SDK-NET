using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace YDN_SDK_NET
{
    /// <summary>
    /// 安全性操作辅助类
    /// </summary>
    public static class SecurityUtil
    {
        /// <summary>
        /// 计算数据的hash值
        /// </summary>
        /// <param name="originalContent">原始数据</param>
        /// <returns>数据的hash值</returns>
        public static string HashData(string originalContent)
        {
            UTF8Encoding byteConverter = new UTF8Encoding();
            byte[] dataToHash = byteConverter.GetBytes(originalContent);
            try
            {
                SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
                byte[] hashData = sha1.ComputeHash(dataToHash);
                return Convert.ToBase64String(hashData);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 对数据进行数字签名
        /// </summary>
        /// <param name="originalContent">待签名数据</param>
        /// <param name="privatekey">RSA私钥</param>
        /// <returns>数字签名后的字符串</returns>
        public static string SignData(string originalContent, string privatekey)
        {
            UTF8Encoding byteConverter = new UTF8Encoding();
            byte[] dataToSign = byteConverter.GetBytes(originalContent);
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportCspBlob(Convert.FromBase64String(privatekey));
                byte[] signedData = rsa.SignData(dataToSign, new SHA1CryptoServiceProvider());
                return Convert.ToBase64String(signedData);
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 验证数字签名
        /// </summary>
        /// <param name="originalContent">原始内容</param>
        /// <param name="signedContent">签名后的内容</param>
        /// <param name="publickey">RSA公钥</param>
        /// <returns>验证通过返回true，否则返回false</returns>
        public static bool VerifySignedData(string originalContent, string signedContent, string publickey)
        {
            byte[] signedData = Convert.FromBase64String(signedContent.Replace(" ", "+"));
            UTF8Encoding byteConverter = new UTF8Encoding();
            byte[] dataToVerify = byteConverter.GetBytes(originalContent);
            try
            {
                RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
                rsa.ImportCspBlob(Convert.FromBase64String(publickey));
                return rsa.VerifyData(dataToVerify, new SHA1CryptoServiceProvider(), signedData);
            }
            catch
            {
                return false;
            }
        }
    }
}
