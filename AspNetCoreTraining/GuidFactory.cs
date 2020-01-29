using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreTraining
{
    public class GuidFactory
    {
        private readonly GuidGenerator _guidGenerator;
        public GuidFactory(GuidGenerator guidGenerator)
        {
            _guidGenerator = guidGenerator;
        }
        public string GetGuid()
        {
            return _guidGenerator.GetGuid();
        }
    }
}
