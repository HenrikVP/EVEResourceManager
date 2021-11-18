using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEResourceManager
{
    internal class Resource : Base
{
        public Resource(){}
        public Resource(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public int? Amount { get; set; }


    }
}
