using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.creating student model with attribute/property/column name of entity/model
namespace EntityframeworkCoreDemo.Entities
{
    //Child table will have forigen key which is primary key of parent table
    public class Student
    {
        public int StudentId { get; set; }//2 pk of student table
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }

        public DateTime? EnrollmentDate { get; set; }

        //public int? BranchId { get; set; }

        public virtual Branch? Branch { get; set; }//5  Referance Naigation property 

    }
}
