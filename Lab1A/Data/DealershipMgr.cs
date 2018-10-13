// I, Dirk Filter, student number 000383606, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using Lab1A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Data
{
    public static class DealershipMgr
    {

        public static List<Dealership> dealerships = new List<Dealership>
        {
            new Dealership { Id=1, Name="Toyota Hamilton", Email="hamtilton@toyota.com", PhoneNumber = "800-121-1525" },
            new Dealership { Id=2, Name="Honda Hamilton", Email="hamilton@honda.com", PhoneNumber = "800-200-1268" },
            new Dealership { Id=3, Name="VW Hamilton", Email="hamilton@vw.com", PhoneNumber = "800-200-2000" },
            new Dealership { Id=4, Name="SAAB Hamilton", Email="hamilton@saab.com", PhoneNumber = "800-200-1000" },
        };

        public static void putDealership(int id, Dealership newDealership)
        {
            var oldDealership = dealerships.Where(dealership => dealership.Id == id).First();
            int index = dealerships.IndexOf(oldDealership);
            dealerships[index] = newDealership;
        }

        public static void postDealership(Dealership newDealership)
        {
            dealerships.Add(newDealership);
        }

        public static List<Dealership> getDealerships()
        {
            return dealerships;
        }

        public static Dealership getDealership(int? id)
        {
            return dealerships.First(dealership => dealership.Id == (int) id);
        }

        public static void deleteDealership(int? id)
        {
            dealerships.RemoveAll(dealership => dealership.Id == (int) id);
        }
    }
}
