
using Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Runner.App.StaticResource
{
    public static class StaticResource
    {
        public static string Output(this string item)
        {
            var root = Directory.GetCurrentDirectory();
            item = root.Substring(0, root.Length - 24);
            return item;
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
