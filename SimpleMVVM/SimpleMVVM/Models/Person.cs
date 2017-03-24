using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMVVM.Models
{
    class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Hometown { get; set; }
        public bool Gender { get; set; }
        public double Salary { get; set; }
        public DateTime Birthday { get; set; }
    }
}
