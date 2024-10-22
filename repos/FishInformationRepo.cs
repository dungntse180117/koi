using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using dao;

namespace repos
{
    public class FishInformationRepo : IFishInformationRepo
    {
        public bool addFish(FishInformation fishInformation) => FishInformationDAO.Instance.addFish(fishInformation);


        public bool delFish(string FishId) => FishInformationDAO.Instance.delFish(FishId);


        public List<FishInformation> GetFishInformation() => FishInformationDAO.Instance.GetFishInformation();


        public FishInformation GetFishInformationByID(string id) => FishInformationDAO.Instance.GetFishInformationById(id);


        public bool updateFish(string FishId) => FishInformationDAO.Instance.updateFish(FishId);

    }
}
