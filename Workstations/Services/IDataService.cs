using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workstations.Services
{
    public interface IDataService<T>
    {
        public Task<T> GetData();
        public Task InsertData(T model);
    }
}
