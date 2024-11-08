using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.creating Branch model/Entity with attribute/property/column name of entity/model
namespace EntityframeworkCoreDemo.Entities
{
    //Parent table will have primary key and it's primary jey will be forigen key for child table
    public class Branch
    {
        public int BranchId { get; set; }//4 pk of branch table
        public string? BranchName { get; set; }
        public string? Description { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public ICollection<Student>? Students { get; set; }//3.Collection navigation property

    }
}
