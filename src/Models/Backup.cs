using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Backup
    {
        public string Path { get; set; }
        public string DatabaseName { get; set; }
        public string Name { get; set; }
        public int BackupType { get; set; }
    }
}
