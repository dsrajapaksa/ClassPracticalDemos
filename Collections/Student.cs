using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Collections
{
    class Student
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("City")]
        public string city { get; set; }
        [DisplayName("School")]
        public string school { get; set; }

    }
}
