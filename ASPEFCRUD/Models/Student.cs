using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPEFCRUD.Models
{
    public class Student
    {
        // Props   
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }
    }
}
