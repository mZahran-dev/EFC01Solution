using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public decimal HourRate { get; set; }

        [InverseProperty("Instructors")]
        [ForeignKey("DeptID")]
        public Department Departments { get; set; }


        [InverseProperty("instructor")]
        public Department Department { get; set; }

        //public int Dept_ID { get; set; }
    }
}
