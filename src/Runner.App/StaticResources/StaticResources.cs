
using Models;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;

namespace Runner.App.StaticResource
{
    public static class StaticResource
    {
        public static string Output(this string item)
        {
            //var host = Dns.GetHostName();
            var root = Directory.GetCurrentDirectory();
            item = root.Substring(0, root.Length - 24);
            return item;
        }

        public static void ReWritejsonFile(string path)
        {

            var root = $"Server={Dns.GetHostName()};Database=master;Trusted_Connection=True;";
            var jsonpath = path + "settings.json";
            var current = path + "Appsettings.json";   

            using (var sr = new StreamReader(jsonpath))
            {
                var jsonfile = sr.ReadToEnd();
                var obj = JObject.Parse(jsonfile);
                var json = (JObject)obj["ConnectionStrings"];
                json["DefaultConnection"] = root;
                var newjson = (string)JsonConvert.SerializeObject(obj);
             
                File.WriteAllTextAsync(current, newjson);
                sr.Close();
            }
        }

        public static IReadOnlyList<Database> Except(this object lst)
        {
            var mod = lst as List<Database>;
            string[] array = { "master", "model", "msdb", "tempdb" };
            for (int i = 0; i < mod.Count; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (mod[i].Databasename == array[j])
                    {
                        mod.Remove(mod[i]);
                    }
                }
            }
            return mod;
        }
    }


}
