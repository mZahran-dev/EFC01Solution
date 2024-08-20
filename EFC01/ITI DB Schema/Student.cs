using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC01.ITI_DB_Schema
{
    //mapping using DataAnnotation
    //[Table("Employees", Schema ="dbo")]
    internal class Student
    {
        
        //[Key]
        public int ID { get; set; }
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        //[Column(TypeName = "varchar")]
        //[MaxLength(50)]
        //[StringLength(50)]
        public string FName { get; set; }
        public string? LName { get; set; }
        //[NotMapped]
        public string? Address { get; set; }

        [Range(21, 50)]
        public int Age { get; set; }

        //[InverseProperty("Student")]
        //[ForeignKey("DeptID")]
        //public Department Department { get; set; }




        //[EmailAddress]
        //[DataType(DataType.EmailAddress)]

        //[PasswordPropertyText]
        //[DataType(DataType.Password)]

        //[Phone]
        //[DataType(DataType.PhoneNumber)]    



    }
}
