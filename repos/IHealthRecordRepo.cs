using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using dao;

namespace repos
{
    public interface IHealthRecordRepo
    {
        public List<HealthRecord> GetHealthRecords();

        
    }
}
