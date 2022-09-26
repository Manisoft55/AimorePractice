using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MVCWithEFCore.Models.DB
{
    public partial class InstituteCmdContext : DbContext
    {
        public InstituteCmdContext()
        {
        }

        public InstituteCmdContext(DbContextOptions<InstituteCmdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=MSP-LAPTOP;Initial Catalog=InstituteCmd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
//            }
//        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

        //    modelBuilder.Entity<Employee>(entity =>
        //    {
        //        entity.ToTable("employees");

        //        entity.Property(e => e.employee_id).HasColumnName("employee_id");

        //        entity.Property(e => e.department_id).HasColumnName("department_id");

        //        entity.Property(e => e.email)
        //            .IsRequired()
        //            .HasMaxLength(100)
        //            .IsUnicode(false)
        //            .HasColumnName("email");

        //        entity.Property(e => e.first_name)
        //            .HasMaxLength(20)
        //            .IsUnicode(false)
        //            .HasColumnName("first_name");

        //        entity.Property(e => e.hire_date)
        //            .HasColumnType("date")
        //            .HasColumnName("hire_date");

        //        entity.Property(e => e.job_id).HasColumnName("job_id");

        //        entity.Property(e => e.last_name)
        //            .IsRequired()
        //            .HasMaxLength(25)
        //            .IsUnicode(false)
        //            .HasColumnName("last_name");

        //        entity.Property(e => e.manager_id).HasColumnName("manager_id");

        //        entity.Property(e => e.phone_number)
        //            .HasMaxLength(20)
        //            .IsUnicode(false)
        //            .HasColumnName("phone_number");

        //        entity.Property(e => e.salary)
        //            .HasColumnType("decimal(8, 2)")
        //            .HasColumnName("salary");
        //    });

        //    OnModelCreatingPartial(modelBuilder);
        //}

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
