using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining
{
    public class GuidGenerator
    {
        public string MyGuid { get; }
        public GuidGenerator()
        {
            MyGuid = Guid.NewGuid().ToString();

        }

        public string GetGuid() {
            return MyGuid;
        }
    }
}
