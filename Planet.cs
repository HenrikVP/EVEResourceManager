using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEResourceManager
{
    internal class Planet : Base
    {
        public List<Resource> Resources { get; set; } = new();
    }
}
