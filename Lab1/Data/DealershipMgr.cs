// I, Aaron Soulliere, student number 000076628, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using Lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Data
{
    public class DealershipMgr
    {
        public static List<Dealership> dealerships { set; get; } = new List<Dealership>();

        public static List<Dealership> GetDealerships()
        {
            return dealerships;
        }

        public static Dealership GetDealership(int id)
        {
            return dealerships.FirstOrDefault(p => p.ID == id);
        }

        public static bool CreateDealership(Dealership dealership)
        {
            //int maxId = dealerships.Max(p => p.ID);
            //dealership.ID = maxId + 1;

            dealerships.Add(dealership);

            return true;
        }

        public static bool UpdateDealership(Dealership dealership)
        {
            Dealership ds = dealerships.FirstOrDefault(p => p.ID == dealership.ID);

            if (ds == null)
            {
                return false;
            }

            int dsId = dealerships.FindIndex(p => p.ID == ds.ID);
            dealerships.RemoveAt(dsId);
            dealerships.Insert(dsId, dealership);

            return true;
        }

        public static bool DeleteDealership(Dealership dealership)
        {
            Dealership ds = dealerships.FirstOrDefault(p => p.ID == dealership.ID);

            if (ds == null)
            {
                return false;
            }

            dealerships.Remove(ds);

            return true;
        }
    }
}
