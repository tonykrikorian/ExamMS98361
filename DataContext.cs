using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamMS98361.Console
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DelegatesContext")
        {

        }
        public DbSet<SystemLog> SystemLogs { get; set; }
    }
}
