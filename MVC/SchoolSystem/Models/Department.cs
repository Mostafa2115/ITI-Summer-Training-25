using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Department
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DeptId { get; set; }
        [StringLength(50)]
        public string DeptName { get; set; }

        public int Capacity { get; set; }

    }
}
