using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmpDeptPortal.Models
{
    public class Employee
    {

        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        [DisplayName("FirstName")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("LastName")]
        public string LastName { get; set; }


        [Required]
        [ForeignKey("Department")]
        [DisplayName("Department Name")]
        public int DeptId { get; set; }


        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        [DisplayName("Phone No")]
        public int PhoneNo { get; set; }

        [Required]
        public int Salary { get; set; }

        internal string GetRuleViolations()
        {
            throw new NotImplementedException();
        }
    }
}
