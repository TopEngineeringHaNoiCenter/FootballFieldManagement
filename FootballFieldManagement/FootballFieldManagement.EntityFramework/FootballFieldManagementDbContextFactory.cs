using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFieldManagement.EntityFramework
{
    public class FootballFieldManagementDbContextFactory
    {
        private readonly Action<DbContextOptionsBuilder> _configureDbContext;

        public FootballFieldManagementDbContextFactory(Action<DbContextOptionsBuilder> configureDbContext)
        {
            _configureDbContext = configureDbContext;
        }
        public FootballFieldManagementDbContext CreateDbContext()
        {
            DbContextOptionsBuilder<FootballFieldManagementDbContext> options = new DbContextOptionsBuilder<FootballFieldManagementDbContext>();

            _configureDbContext(options);

            return new FootballFieldManagementDbContext(options.Options);
        }
    }
}
