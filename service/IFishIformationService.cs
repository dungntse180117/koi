using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;

namespace service
{
    public interface IFishIformationService
    {
        public List<FishInformation> GetFishInformation();

        public FishInformation GetFishInformation(string id);

        public bool addFish(FishInformation fishInformation);

        public bool delFish(String FishId);

        public bool UpdateFish(String FishId);
    }
}
