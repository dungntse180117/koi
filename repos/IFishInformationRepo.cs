using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;

namespace repos
{
    public interface IFishInformationRepo
    {
        public List<FishInformation> GetFishInformation();

        public FishInformation GetFishInformationByID(String id);

        public bool addFish(FishInformation fishInformation);   

        public bool delFish(String FishId);

        public bool updateFish(String FishId);
    }
}
