using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Context : DbContext
    {
        public Context():base("Data Source=.;Initial Catalog=dbdbdbDB;Integrated Security=True")
        {

        }

        public virtual DbSet<Employee> employees { get; set; }
    }
}
