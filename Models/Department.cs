using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmpDeptPortal.Models
{
    public class Department
    {
        
        [Key]
        public int DeptId { get; set; }

        
        [Required]
        [DisplayName("Department Name")]
        public string DeptName { get; set; }

        
    }
}
