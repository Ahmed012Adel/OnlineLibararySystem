using Libarary.Domain.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Infrustructure.Persistent.Data
{
    public class ApplicationIntializer(ApplicationDbcontext dbcontext) : IApplicationContextIntializer
    {
        public async Task UpdateDatabaseAsync()
        {
            var pendingMigration = await dbcontext.Database.GetPendingMigrationsAsync();

            if (pendingMigration.Any())
            {
                await dbcontext.Database.MigrateAsync();
            }
        }
    }
}
