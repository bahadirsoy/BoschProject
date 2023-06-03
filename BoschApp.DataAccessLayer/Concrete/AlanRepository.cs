using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class AlanRepository : IAlanRepository
    {
        private readonly DataContext _context;

        public AlanRepository(DataContext context)
        {
            _context = context;
        }

        public bool AlanExist(int alanId)
        {
            return _context.Alans.Any(a => a.Id == alanId);
        }

        public Alan GetAlan(int alanId)
        {
            return _context.Alans.Where(a => a.Id == alanId).FirstOrDefault();
        }

        public ICollection<Alan> GetAlans()
        {
            return _context.Alans.ToList();
        }

        public ICollection<Departman> GetDepartmansByAlan(int alanId)
        {
            return _context.Departmants.Where(d => d.Alan.Id == alanId).ToList();
        }
    }
}
