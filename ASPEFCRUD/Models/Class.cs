using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPEFCRUD.Models
{
    public class Class
    {
        // Props
        public int Id { get; set; }
        public string ClassName { get; set; }

        // Foreign Key
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
