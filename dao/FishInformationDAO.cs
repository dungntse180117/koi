using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Bussinessobject;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace dao
{
    public class FishInformationDAO
    {
        private KoifishDbContext db;
        private static FishInformationDAO instance;

        public FishInformationDAO()
        {
            db = new KoifishDbContext();
        }

        public static FishInformationDAO Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new FishInformationDAO();

                }
                return instance;
            }
        }

        public FishInformation GetFishInformationById(String id)
        {
            return db.FishInformations.SingleOrDefault(m => m.FishId.Equals(id));
        }

        public List<FishInformation> GetFishInformation()
        {
            return db.FishInformations.ToList();
        }

        public FishInformation GetFishInformation(String id)
        {
            return db.FishInformations.SingleOrDefault(m => m.FishId.Equals(id));
        }
        
        public bool addFish(FishInformation fishInformation)
        {
            bool isSuccess = false;

            if (fishInformation == null)
            {
                db.FishInformations.Add(fishInformation);
                db.SaveChanges();
                isSuccess = true;
            }
            return isSuccess;
        }

        public bool delFish(String fishId)
        {
            bool isSuccess = false;
            FishInformation fish = GetFishInformation(fishId);
            try
            {
                if (fish != null)
                {
                    db.FishInformations.Remove(fish);
                    db.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }

        public bool updateFish(String FishId)
        {
            bool isSuccess = false;
            FishInformation fish = this.GetFishInformationById(FishId);
            try
            {
                if (fish != null)
                {
                    db.Entry<FishInformation>(fish).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return isSuccess;
        }
    }
    }

