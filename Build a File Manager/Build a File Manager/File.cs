using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Build_a_File_Manager
{
    public class File
    {
        public string name { get; set; }
        public string type { get; set; }
        public string content { get; set; }

        public File(string name, string type, string content)
        {
            this.name = name;
            this.type = type;
            this.content = content;
        }
    }
}
