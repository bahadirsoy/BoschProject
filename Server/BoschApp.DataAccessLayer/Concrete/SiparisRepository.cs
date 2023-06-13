using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class SiparisRepository : ISiparisRepository
    {
        private readonly DataContext _context;

        public SiparisRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateSiparis(Siparis siparis)
        {
            _context.Siparises.Add(siparis);
            return Save();
        }

        public Enjektor GetEnjektorBySiparis(int siparisId)
        {
            return _context.Siparises.Where(s => s.Id == siparisId).Select(s => s.Enjektor).FirstOrDefault();
        }

        public Siparis GetSiparis(int siparisId)
        {
            return _context.Siparises.Where(s => s.Id == siparisId).FirstOrDefault();
        }

        public ICollection<Siparis> GetSiparisAndEnjektors()
        {
            return _context.Siparises.Include(s => s.Enjektor).ToList();
        }

        public ICollection<Siparis> GetSiparises()
        {
            return _context.Siparises.ToList();
        }

        public ICollection<Uretim> GetUretimsBySiparis(int siparisId)
        {
            return _context.Uretims.Where(u => u.Siparis.Id == siparisId).ToList();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool SiparisExist(int siparisId)
        {
            return _context.Siparises.Any(s => s.Id == siparisId);
        }

        public bool UpdateSiparis(Siparis siparis)
        {
            _context.Siparises.Update(siparis);
            return Save();
        }
    }
}
