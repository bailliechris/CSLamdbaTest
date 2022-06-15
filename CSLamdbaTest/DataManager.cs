using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSLamdbaTest.Models;
using CSLamdbaTest.Data;

namespace CSLamdbaTest
{
    public class DataManager
    {
        private readonly MVContext DB = new MVContext(); 

        public DataManager()
        {

        }

        public Bio AddBio(string name)
        {
            Bio bio = new Bio();

            bio.FirstName = name;
            bio.LastName = "Baillie";
            bio.type = "executive";

            DB.Bios.Add(bio);

            return bio;
        }

        public void SaveChanges()
        {
            DB.SaveChanges();
        }
    }
}
