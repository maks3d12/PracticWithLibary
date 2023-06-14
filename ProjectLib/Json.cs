using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLib
{
     public class Json
    {
        public static void MySerialize<T>(string path, T Content)
        {
            if (!File.Exists(path))
            {
                FileStream filestream = File.Create(path);
                filestream.Dispose();
            }
            string json = JsonConvert.SerializeObject(Content);
            File.WriteAllText(path, json);
        }
        static public T ReadFromFile<T>(string path)
        {
            
            string resultInfo = File.ReadAllText(path);
            T result = JsonConvert.DeserializeObject<T>(resultInfo);
           
            return result;
        }
    }
}
