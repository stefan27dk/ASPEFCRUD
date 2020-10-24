using ASPEFCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPEFCRUD
{
    //DB CONTEXT
    public class AppContext :DbContext 
    {
        // Db Sets
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; }


        // Constructor
        public AppContext(DbContextOptions<AppContext> options): base(options)
        {

        }
    }
}
