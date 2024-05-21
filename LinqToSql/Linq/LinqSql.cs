using Microsoft.EntityFrameworkCore;

namespace LinqToSql.Linq
{
    public class LinqSql:DbContext
    {
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("server=LAPTOP-CBE07JIV;uid=sa;database=dbOtp;pwd=umer908;TrustServerCertificate=True");
        }

        public DbSet<tbl_student> Student { get; set; }

    }
}
