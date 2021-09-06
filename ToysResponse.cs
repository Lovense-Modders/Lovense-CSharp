using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LovenseAPI
{
    class ToysResponse
    {
        public string type;
        public int code;
        public Dictionary<string, Toy> data;
    }
}
