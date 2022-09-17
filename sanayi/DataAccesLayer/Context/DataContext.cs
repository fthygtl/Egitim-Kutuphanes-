using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Thesis> Thesis { get; set; }
        public DbSet<Units> Units { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<SSS>SSS { get; set; }


    }
}
