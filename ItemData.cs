using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Developer_Assistant
{
    public class ItemData
    {
        public int ID;
        public List<string> pathsToFile = new List<string>();
        public string projectName;
    }
}
