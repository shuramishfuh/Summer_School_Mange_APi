using Control.Context;
using Control.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;


namespace Control.GetRam
{
    public class GetRan
    {
        private readonly ControlContext _context;

        public GetRan(ControlContext context)
        {
            _context = context;
        }

        public static string GetRandomAlphanumericString()
        {
            const string alphanumericCharacters =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "abcdefghijklmnopqrstuvwxyz" +
                "0123456789";
            return GetRandomString(40, alphanumericCharacters);
        }

        public static string GetRandomString(int length, IEnumerable<char> characterSet)
        {
            if (length < 0)
                throw new ArgumentException("length must not be negative", "length");
            if (length > int.MaxValue / 8) // 250 million chars ought to be enough for anybody
                throw new ArgumentException("length is too big", "length");
            if (characterSet == null)
                throw new ArgumentNullException("characterSet");
            var characterArray = characterSet.Distinct().ToArray();
            if (characterArray.Length == 0)
                throw new ArgumentException("characterSet must not be empty", "characterSet");

            var bytes = new byte[length * 8];
            var result = new char[length];
            using (var cryptoProvider = new RNGCryptoServiceProvider())
            {
                cryptoProvider.GetBytes(bytes);
            }
            for (int i = 0; i < length; i++)
            {
                ulong value = BitConverter.ToUInt64(bytes, i * 8);
                result[i] = characterArray[value % (uint)characterArray.Length];
            }
            return new string(result);
        }

        public void DoingApiKey()
        {
            
            string newKey = GetRandomAlphanumericString();
            ApiKey apikey = _context.ApiKeys.Find((Int16)1);
            apikey.Key = newKey;
            _context.SaveChanges();

        }
    }
}
