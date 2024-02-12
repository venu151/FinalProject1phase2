using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProject1.Models
{
    [Table("DeptMaster")]
    public class Deptmaster
    {
        [Key]
        public int DeptCode { get; set; }
        public string? DeptName { get; set; }
        public virtual ICollection<EmpProfile>? EmpProfiles { get; set; }
    }
}
