using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    [Table("Class")]
    public class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }
        [Key]
        public int ClassID { get; set; }
        public string ClassName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
