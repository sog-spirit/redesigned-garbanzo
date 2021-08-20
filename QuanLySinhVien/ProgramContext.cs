using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    public class ProgramContext : DbContext
    {
        public ProgramContext() : base("name = ModelContext")
        {
            Database.SetInitializer<ProgramContext>(new CreateDatabase());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Student> students { get; set; }
        public virtual DbSet<Class> classes { get; set; }
    }
}
