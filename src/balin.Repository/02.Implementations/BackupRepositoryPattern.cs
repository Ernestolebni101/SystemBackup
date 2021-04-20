using balin.Repository._01.Interfaces;
using Dapper;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Transactions;

namespace balin.Repository._02.Implementations
{
    public class BackupRepositoryPattern : IBackupRepositoryPattern
    {
        private readonly IDbConnection _db;
        public BackupRepositoryPattern(string connstring)
        {
            _db = new SqlConnection(connstring);
        }

        public bool Insert(Backup model)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@path", value: model.Path);
            parameters.Add("@namebak", value: model.Name);
            parameters.Add("@type", value: model.BackupType, dbType: DbType.Int32);
            parameters.Add("@dbname", value: model.DatabaseName);
            var notify = this._db.Execute("Sp_Backup", parameters, commandType: CommandType.StoredProcedure);
            return (notify == 1) ? true : false;
        }
    }
}
