using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Enrollment_Information
{
    internal class Department
    {
        public string name;
        public int code;
        public List<Student> stdlis = new List<Student>();
    }
}
