using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace AccountAppSerialization
{
    internal class SerializeDeserialize
    {
        public static void SerializeData(List<Account> account)
        {
            File.WriteAllText("Accountdata.json", JsonConvert.SerializeObject(account));
        }

        public static List<Account> DeserializeData() 
        {
           List<Account> account =new List<Account>();
            string filename = "AccountData.json";
            if (File.Exists(filename))
            {
                string json = File.ReadAllText(filename);
                account = JsonConvert.DeserializeObject<List<Account>>(json);
            }
            else
            {
                File.WriteAllText("Accountdata.json", JsonConvert.SerializeObject(account));

            }
            return account;
        }
    }
}
