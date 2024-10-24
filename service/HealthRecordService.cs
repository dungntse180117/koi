using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using Microsoft.IdentityModel.Tokens;

namespace service
{
    public class HealthRecordService : IHealthRecordService
    {
        private readonly IHealthRecordService healthRecordRepo;

        public HealthRecordService()
        {
            healthRecordRepo = new HealthRecordService();
        }
        public List<HealthRecord> GetHealthRecords()
        {
           
            throw new NotImplementedException();
        }
    }
}
