using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
namespace dao
{
    public class HealthRecordDAO
    {
        private KoifishDbContext context;
        private static HealthRecordDAO instance;

        public static HealthRecordDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new HealthRecordDAO();

                }
                return instance;
            }
        }

        public HealthRecordDAO ()
        {
            context = new KoifishDbContext();
        }
        public List<HealthRecord> GetHealthRecords()
        {
            return context.HealthRecords.ToList();
        }
      
       

    }
}
