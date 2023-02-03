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
        //private static readonly JsonSerializerOptions _options
        //  = new () { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };


        public static void WriteJSON(object obj, string fileName)
        {
            /*var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };*/
            var jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
        }
    }
}
