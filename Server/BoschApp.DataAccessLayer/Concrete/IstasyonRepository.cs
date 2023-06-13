using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class IstasyonRepository : IIstasyonRepository
    {
        private readonly DataContext _context;

        public IstasyonRepository(DataContext context)
        {
            _context = context;
        }

        public ICollection<AltParca> GetAltParcaAndStokAlaniByIstasyon(int istasyonId)
        {
            return _context.AltParcas.Where(a => a.Istasyon.Id == istasyonId).Include(a => a.StokAlanis).ToList();
        }

        public ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId)
        {
            return _context.AltParcas.Where(a => a.Istasyon.Id == istasyonId).ToList();
        }

        public Istasyon GetIstasyon(int istasyonId)
        {
            return _context.Istasyons.Where(i => i.Id == istasyonId).FirstOrDefault();
        }

        public ICollection<Istasyon> GetIstasyons()
        {
            return _context.Istasyons.ToList();
        }

        public bool IstasyonExist(int istasyonId)
        {
            return _context.Istasyons.Any(i => i.Id == istasyonId);
        }
    }
}
