using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using repos;

namespace service
{
    public class FishInformationService : IFishIformationService
    {

        private IFishInformationRepo repo;

        public FishInformationService()
        {
            repo = new FishInformationRepo();
        }
        public bool addFish(FishInformation fishInformation)
        {
            return repo.addFish(fishInformation);
        }

        public bool delFish(string FishId)
        {
            return repo.delFish(FishId);
        }

        public List<FishInformation> GetFishInformation()
        {
            return repo.GetFishInformation();
        }

        public FishInformation GetFishInformation(string id)
        {
            return repo.GetFishInformationByID(id);
        }

        public bool UpdateFish(string FishId)
        {
            return repo.updateFish(FishId);
        }
    }
}
