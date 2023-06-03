using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class KisimRepository : IKisimRepository
    {
        private readonly DataContext _context;

        public KisimRepository(DataContext context)
        {
            _context = context;
        }

        public Departman GetDepartmanByKisim(int kisimId)
        {
            return _context.Kisims.Where(k => k.Id == kisimId).Select(d => d.Departman).FirstOrDefault();
        }

        public ICollection<Enjektor> GetEnjektorsByKisim(int kisimId)
        {
            return _context.Enjektors.Where(e => e.Kisim.Id == kisimId).ToList();
        }

        public Kisim GetKisim(int kisimId)
        {
            return _context.Kisims.Where(k => k.Id == kisimId).FirstOrDefault();
        }

        public ICollection<Kisim> GetKisims()
        {
            return _context.Kisims.ToList();
        }

        public bool KisimExist(int kisimId)
        {
            throw new NotImplementedException();
        }
    }
}
