using Microsoft.EntityFrameworkCore;
using P055_DB_DataSeed.Models;
using P055_DB_DataSeed.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P055_DB_DataSeed.Database
{
    public class ParduotuveRepository : IParduotuveRepository
    {
        private readonly ParduotuveContext _context;

        public ParduotuveRepository(ParduotuveContext context)
        {
            _context = context;
        }

        public List<Batas> GetBatai() =>_context.Batai.Include(x => x.Dydziai).ToList();

        public void InsertPardavimasIrSumazintiKieki(int dydzioId, int kiekis)
        {
            var pardavimas = new Pardavimas
            {
                BatuDydisId = dydzioId,
                Kiekis = kiekis,
            };
            _context.Add(pardavimas);

            var batuDydis = _context.BatuDydziai.Find(dydzioId);
            batuDydis.Kiekis = batuDydis.Kiekis - kiekis;


            _context.SaveChanges();
        }
    }
}
