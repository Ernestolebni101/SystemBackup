using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace balin.Repository._01.Interfaces
{
    public interface IBackupRepositoryPattern
    {
        bool Insert(Backup model);
    }
}
