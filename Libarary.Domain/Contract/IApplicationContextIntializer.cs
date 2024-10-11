using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libarary.Domain.Contract
{
    public interface IApplicationContextIntializer
    {
        Task UpdateDatabaseAsync();
        //Task DataSeedAsync();
    }
}
