using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using P055_DB_DataSeed.Database;
using P055_DB_DataSeed.Models;
using P055_DB_DataSeed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P055_DB_DataSeed.Database.Tests
{
    [TestClass()]
    public class ParduotuveRepositoryTests
    {
        private ParduotuveContext context;

        [TestInitialize]
        public void OnInit()
        {
            var options = new DbContextOptionsBuilder<ParduotuveContext>()
                .UseInMemoryDatabase(databaseName: "Parduotuve")
                .Options;
            
            context = new ParduotuveContext(options);
            context.Batai.AddRange(new Batas[]
           {
                new Batas {
                    BatasId = 1,
                    Pavadinimas = "Kedai",
                    Tipas = "Vyriški",
                    Kaina = 100M,
                },
           });
            context.BatuDydziai.AddRange(new BatuDydis[]
            {
                new BatuDydis { Id = 1, BatasId = 1, Dydis = 42, Kiekis = 10 },
                new BatuDydis { Id = 2, BatasId = 1, Dydis = 43, Kiekis = 11 },
                new BatuDydis { Id = 3, BatasId = 1, Dydis = 44, Kiekis = 12 },
                new BatuDydis { Id = 4, BatasId = 1, Dydis = 45, Kiekis = 14 },
            });
            context.SaveChanges();
        }

        [TestMethod()]
        public void InsertPardavimasIrSumazintiKiekiTest()
        {
            IParduotuveRepository parduotuve = new ParduotuveRepository(context);
            parduotuve.InsertPardavimasIrSumazintiKieki(2, 5);

            Assert.AreEqual(6, context.BatuDydziai.Find(2).Kiekis);
            Assert.AreEqual(5, context.Pardavimai.First(x => x.BatuDydisId == 2).Kiekis);
            Assert.AreEqual(500, context.Pardavimai.First(x => x.BatuDydisId == 2).Isleista);

        }
    }
}