using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace VĐKO1721050102.Models
{
    public partial class OanhDbContext : DbContext
    {
        public OanhDbContext()
            : base("name=OanhDbContext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Lecture> Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lecture>()
                .Property(e => e.Faculty)
                .IsUnicode(true);
            modelBuilder.Entity<Lecture>()
               .Property(e => e.Department)
               .IsUnicode(true);
        }
    }
}
