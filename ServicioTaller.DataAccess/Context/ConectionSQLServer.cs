using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ServicioTaller.DataAccess.Context
{
    public class ConectionSQLServer : DbContext
    {
        public ConectionSQLServer(DbContextOptions<ConectionSQLServer> options) : base(options)
        {
            //
        }
    }
}
