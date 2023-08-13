using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.DbAccess.Shared.Enums;

namespace Zen.DbAccess.Shared.Models;

public class ConnectionStringModel
{
    public string DbType { get; set; } = string.Empty;
    public string ConnectionString { get; set; } = string.Empty;
    public string TimeZone { get; set; } = string.Empty;

    public DbConnectionType DbConnectionType
    {
        get
        {
            if (string.IsNullOrEmpty(DbType))
                return DbConnectionType.Oracle;

            return (DbConnectionType)Enum.Parse(typeof(DbConnectionType), DbType);
        }
    }
}
