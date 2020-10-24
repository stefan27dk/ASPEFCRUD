using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPEFCRUD.Models
{
    public class Class
    {
        // Props
        [Key]
        public int Id { get; set; }

        [Column(TypeName ="nvarchar(30)")]   
        public string ClassName { get; set; }

        // Foreign Key
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
