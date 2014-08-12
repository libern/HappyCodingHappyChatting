using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HappyCoding
{
    class SomelineRequestJson
    {
        public String SomelineActionCode;
        public Dictionary<String, String> data;


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this); ;
        }
    }
}
