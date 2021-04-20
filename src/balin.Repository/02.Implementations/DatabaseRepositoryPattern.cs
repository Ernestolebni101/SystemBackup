using balin.Repository._01.Interfaces;
using Dapper;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace balin.Repository._02.Implementations
{
    public class DatabaseRepositoryPattern : IDatabaseRepositoryPattern
    {
        private readonly IDbConnection _db;
        public DatabaseRepositoryPattern(string connstring)
        {
            _db = new SqlConnection(connstring);
        }
        public IReadOnlyList<Database> GetDatabases()
        {
            using (var multplresult = this._db.QueryMultiple("SPgetDatabases", commandType: CommandType.StoredProcedure))
            {
                var datbase = multplresult.Read<Database>().ToList();
                return datbase ?? throw new  Exception();
            }
        }
    }
}
