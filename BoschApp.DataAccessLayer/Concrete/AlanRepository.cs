using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AlanEntity;
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

        public ICollection<Alan> GetAlans()
        {
            return _context.Alans.ToList();
        }
    }
}
