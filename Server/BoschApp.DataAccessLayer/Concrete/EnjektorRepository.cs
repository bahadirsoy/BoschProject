using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class EnjektorRepository : IEnjektorRepository
    {
        private readonly DataContext _context;

        public EnjektorRepository(DataContext context)
        {
            _context = context;
        }

        public bool EnjektorExist(int enjektorId)
        {
            return _context.Enjektors.Any(e => e.Id == enjektorId);
        }

        public AltParca GetAltParcaByEnjektorAndIstasyon(int enjektorId, int istasyonId)
        {
            return _context.EnjektorAltParcas.Where(ea => ea.EnjektorId == enjektorId)
                .Select(ea => ea.AltParca)
                .Where(a => a.Istasyon.Id == istasyonId).FirstOrDefault();
        }

        public ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId)
        {
            return _context.EnjektorAltParcas.Where(ea => ea.Enjektor.Id == enjektorId).Select(ea => ea.AltParca).ToList();
        }

        public Enjektor GetEnjektor(int enjektorId)
        {
            return _context.Enjektors.Where(e => e.Id == enjektorId).FirstOrDefault();
        }

        public ICollection<Enjektor> GetEnjektors()
        {
            return _context.Enjektors.ToList();
        }

        public Kisim GetKisimByEnjektor(int enjektorId)
        {
            return _context.Enjektors.Where(e => e.Id == enjektorId).Select(e => e.Kisim).FirstOrDefault();
        }
    }
}
