using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ChainOfResponsibility
{
    public class Factory
    {
        public LicenceChain GetLicenceChain()
        {
            return new LicenceChain();
        }
    }

    public class LicenceChain
    {
        private IResponsibility _chain;

        public LicenceChain()
        {
            var resp1 = new LicenceKeyIsNotEmpty();
            var resp2 = new LicenceKeyIsValid();

            resp1.Next = resp2;
            _chain = resp1;
        }

        public bool Validate(string file)
        {
            var text = File.ReadAllText(file);
            var licence = JsonConvert.DeserializeObject<LicenceFile>(text);

            var item = _chain;
            bool result = true;
            do
            {
                result = result && item.Execute(licence);
                item = item.Next;
            } while (item.Next != null);

            return result;
        }
    }

    public class LicenceFile
    {
        public Licence Licence { get; set; }
        public string Key { get; set; }
    }

    public class Licence
    {
        public string Client { get; set; }
        public string Key { get; set; }
    }

    public class LicenceKeyIsValid : IResponsibility
    {
        public IResponsibility Next
        {
            get;
            set;
        }

        public bool Execute(LicenceFile licence)
        {
            return licence.Key == CreateMD5(licence.Licence.Client);
        }

        public static string CreateMD5(string input)

        {

            // Use input string to calculate MD5 hash

            using (MD5 md5 = MD5.Create())

            {

                byte[] inputBytes = Encoding.ASCII.GetBytes(input);

                byte[] hashBytes = md5.ComputeHash(inputBytes);



                // Convert the byte array to hexadecimal string

                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)

                {

                    sb.Append(hashBytes[i].ToString("X2"));

                }

                return sb.ToString();

            }
        }
    }

    public class LicenceKeyIsNotEmpty : IResponsibility
    {
        public IResponsibility Next
        {
            get;
            set;
        }

        public bool Execute(LicenceFile licence)
        {
            return !string.IsNullOrEmpty(licence.Licence.Client);
        }
    }

    public interface IResponsibility
    {
        IResponsibility Next { get; set; }
        bool Execute(LicenceFile licence);
    }
}
