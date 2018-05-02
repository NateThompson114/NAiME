using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NAiME.Tools
{
    public static class Sha
    {
        /// <summary>
        /// Hasher takes in a dynamic Class
        /// </summary>
        /// <param name="sha">Use SHA1.Create(), SHA256.Create(), SHA384.Create(), SHA512.Create()</param>
        /// <param name="inputString"></param>
        /// <returns>SHA Hash</returns>
        internal static string Hasher(dynamic sha, string inputString)
        {
            using (sha)
            {
                var bytes = Encoding.UTF8.GetBytes(inputString);
                var hash = sha.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }
        }

        /// <summary>
        /// HashThis takes in a dynamic Class
        /// </summary>
        /// <param name="sha">Use SHA1.Create(), SHA256.Create(), SHA384.Create(), SHA512.Create()</param>
        /// <param name="inputString"></param>
        /// <returns>SHA Hash</returns>
        public static string HashThis(this string inputString, dynamic sha)
        {
            using (sha)
            {
                var bytes = Encoding.UTF8.GetBytes(inputString);
                var hash = sha.ComputeHash(bytes);
                return GetStringFromHash(hash);
            }
        }

        private static string GetStringFromHash(IEnumerable<byte> hash)
        {
            var result = new StringBuilder();

            foreach (var b in hash)
                result.Append(b.ToString("X2"));

            return result.ToString();
        }
    }
}