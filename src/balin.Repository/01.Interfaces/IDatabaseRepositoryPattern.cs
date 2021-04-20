using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace balin.Repository._01.Interfaces
{
    public interface IDatabaseRepositoryPattern
    {
        IReadOnlyList<Database> GetDatabases();
    }
}
