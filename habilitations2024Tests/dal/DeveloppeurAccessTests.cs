using Microsoft.VisualStudio.TestTools.UnitTesting;
using habilitations2024.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using habilitations2024.model;

namespace habilitations2024.dal.Tests
{
    [TestClass()]
    public class DeveloppeurAccessTests
    {
        [TestMethod()]
        public void GetLesDeveloppeursTest()
        {
            DeveloppeurAccess developpeurAccess = new DeveloppeurAccess();

            List<Developpeur> admin = developpeurAccess.GetLesDeveloppeurs("admin");
            Assert.AreEqual(4, admin.Count);
        }

        [TestMethod()]
        public void GetLesDeveloppeursTest1()
        {
            DeveloppeurAccess developpeur = new DeveloppeurAccess();
            string profilFiltre = "";
            List<Developpeur> lesDeveloppeurs = developpeur.GetLesDeveloppeurs(profilFiltre);
            Assert.AreEqual(23, lesDeveloppeurs.Count );
        }
    }
}