using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Web;
using System.Data;
using MySql.Data.MySqlClient;

namespace yameApp
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    class Context : DbContext
    {
        public Context() 
            : base("DbConnection")
        { }

        public DbSet<user> users { get; set; }
    }
}
