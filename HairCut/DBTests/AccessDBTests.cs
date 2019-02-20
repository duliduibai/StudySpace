using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DB.Tests
{
    [TestClass()]
    public class AccessDBTests
    {
        [TestMethod()]
        public void GetAccountTest()
        {
            DataTable dt = new DataTable();
            try
            {
                AccessDB accessDB = new AccessDB();
                dt = accessDB.GetAccount();
            }
            catch (Exception ex)
            {
                Assert.Fail();
            }
            Assert.AreNotEqual(dt, null);
        }
    }
}