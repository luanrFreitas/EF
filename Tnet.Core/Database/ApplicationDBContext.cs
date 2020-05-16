using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tnet.Core.Database
{
    class ApplicationDBContext : DbContext
    {
        DbSet<Funcionario> pop2;

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) :
            base(options)
        {

        }
    }
}
