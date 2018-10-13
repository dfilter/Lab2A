// I, Dirk Filter, student number 000383606, certify that this material is my
// original work. No other person's work has been used without due
// acknowledgement and I have not made my work available to anyone else.

using Lab1A.Data;
using Lab1A.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestLab1A
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestGetAll()
        {
            var dealerships = DealershipMgr.getDealerships();
            int listCount = dealerships.Count;
            Assert.AreEqual(listCount, 4);
        }

        [TestMethod]
        public void TestGetOne()
        {
            var dealership = DealershipMgr.getDealership(2);
            Assert.AreEqual(dealership.Id, 2);
        }

        [TestMethod]
        public void TestPost()
        {
            Dealership newDealership = new Dealership { Id = 5, Name = "Audi Hamilton", Email = "hamtilton@audi.com", PhoneNumber = "800-121-1525" };
            DealershipMgr.postDealership(newDealership);
            var afterDealerships = DealershipMgr.getDealerships();
            Assert.AreNotEqual(afterDealerships.Count, 4);
        }

        [TestMethod]
        public void TestPut()
        {
            var dealership = DealershipMgr.getDealership(2);
            string oldName = dealership.Name;
            Dealership newDealership = new Dealership { Id = 2, Name = "KIA Hamilton", Email = "hamtilton@kia.com", PhoneNumber = "800-121-1525" };
            DealershipMgr.putDealership(2, newDealership);
            var dealerships = DealershipMgr.getDealerships();
            Assert.AreNotEqual(oldName, dealerships[1].Name);
        }

        [TestMethod]
        public void TestDelete()
        {
            var dealerships = DealershipMgr.getDealerships();
            int oldCount = dealerships.Count;
            DealershipMgr.deleteDealership(2);
            int newCount = dealerships.Count;
            Assert.AreNotEqual(oldCount, newCount);
        }
    }
}
