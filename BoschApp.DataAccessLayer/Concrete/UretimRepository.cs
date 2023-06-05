using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class UretimRepository : IUretimRepository
    {
        private readonly DataContext _context;

        public UretimRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateUretim(Uretim uretim)
        {
            _context.Uretims.Add(uretim);
            return Save();
        }

        public bool DeleteUretim(Uretim uretim)
        {
            _context.Uretims.Remove(uretim);
            return Save();
        }

        public AltParca GetAltParcaByUretim(int uretimId)
        {
            return _context.Uretims.Where(u => u.Id == uretimId).Select(u => u.AltParca).FirstOrDefault();
        }

        public Siparis GetSiparisByUretim(int uretimId)
        {
            return _context.Uretims.Where(u => u.Id == uretimId).Select(u => u.Siparis).FirstOrDefault();
        }

        public Uretim GetUretim(int uretimId)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UretimExist(int uretimId)
        {
            return _context.Uretims.Any(u => u.Id == uretimId);
        }
    }
}
