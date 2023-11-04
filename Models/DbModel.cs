using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Zen.DbAccess.Shared.Attributes;

namespace Zen.DbAccess.Shared.Models;

public class DbModel : JsonModel
{
    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public DbSqlUpdateModel dbModel_sql_update { get; set; } = new DbSqlUpdateModel();

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public DbSqlInsertModel dbModel_sql_insert { get; set; } = new DbSqlInsertModel();

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public PropertyInfo[]? dbModel_properties { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public List<string>? dbModel_dbColumns { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public Dictionary<string, string>? dbModel_column_map { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public string dbModel_pkName { get; set; } = string.Empty;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public PropertyInfo? dbModel_primaryKey { get; set; } = null;
}
