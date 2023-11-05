﻿using System;
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
    public HashSet<string>? dbModel_dbColumns { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public List<string>? dbModel_primaryKey_dbColumns { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public Dictionary<string, PropertyInfo>? dbModel_dbColumn_map { get; set; } = null;

    [DbModelPropertyIgnore]
    [Newtonsoft.Json.JsonIgnore]
    [System.Text.Json.Serialization.JsonIgnore]
    public Dictionary<string, string>? dbModel_prop_map { get; set; } = null;

    public void CopyDbModelPropsFrom(DbModel model)
    {
        dbModel_sql_update = model.dbModel_sql_update;
        dbModel_sql_insert = model.dbModel_sql_insert;
        dbModel_dbColumns = model.dbModel_dbColumns;
        dbModel_primaryKey_dbColumns = model.dbModel_primaryKey_dbColumns;
        dbModel_dbColumn_map = model.dbModel_dbColumn_map;
        dbModel_prop_map = model.dbModel_prop_map;
    }
}
