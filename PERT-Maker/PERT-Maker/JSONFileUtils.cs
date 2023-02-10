using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PERT_Maker
{
    class JSONFileUtils
    {
        private static readonly JsonSerializerOptions _options
          = new JsonSerializerOptions() {};

        public static void WriteJSON(object obj, string fileName)
        {
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true,
                IncludeFields = true
            };
            var jsonString = JsonSerializer.Serialize(obj, options);
            //Console.WriteLine(jsonString); //Debugging
            File.WriteAllText(fileName, jsonString);
        }

        public static void WriteTXT(string txt, string filename)
        {
            File.AppendAllText(filename, txt + Environment.NewLine);
        }
    }
}
