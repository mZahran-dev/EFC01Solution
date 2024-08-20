using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        //public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }

        // [InverseProperty("Department")]
        public ICollection<Student> Student { get; set; } = new HashSet<Student>();

        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();


        //[InverseProperty("Department")]
        //[ForeignKey("Ins_ID")]
        //public Instructor instructor { get; set; }

    }
}
