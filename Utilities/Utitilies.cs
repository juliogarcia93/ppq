using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utilities
{
    public static class Utitilies
    {
        public static dynamic LoadJson(string filePath)
        {
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                dynamic array = JsonConvert.DeserializeObject(json);
                return array;
            }
        }
    }
}
