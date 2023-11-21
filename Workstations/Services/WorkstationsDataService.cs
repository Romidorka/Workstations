using Postgrest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Workstations.Models;

namespace Workstations.Services
{
    public class WorkstationsDataService : IDataService<Workstation>
    {
        public WorkstationsDataService() { 
        
        }

        Task<Workstation> GetData()
        {
            
        }

        Task IDataService<Workstation>.InsertData(Workstation model)
        {
            
        }
    }
}
