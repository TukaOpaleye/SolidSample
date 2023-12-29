using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class PolicySerialiazer
    {
        public Policy GetPolicyFromJson(string policyJson)
        {
            var policy = JsonConvert.DeserializeObject<Policy>(policyJson,
                new StringEnumConverter());

            return policy;

        }
    }
}
