﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zen.DbAccess.Shared.ContractResolvers;

namespace Zen.DbAccess.Shared.Models;

public class JsonModel
{
    public string ToJson()
    {
        return JsonConvert.SerializeObject(
            this,
            Formatting.None,
            new JsonSerializerSettings { ContractResolver = new JsonModelContractResolver() }
        );
    }

    public override string ToString()
    {
        return ToJson();
    }
}
