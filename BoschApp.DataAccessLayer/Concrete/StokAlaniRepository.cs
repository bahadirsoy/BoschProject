using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class StokAlaniRepository : IStokAlaniRepository
    {
        private readonly DataContext _context;

        public StokAlaniRepository(DataContext context)
        {
            _context = context;
        }

        public StokAlani GetStokAlani(int stokAlaniId)
        {
            return _context.StokAlanis.Where(s => s.Id == stokAlaniId).FirstOrDefault();
        }

        public ICollection<StokAlani> GetStokAlanis()
        {
            return _context.StokAlanis.ToList();
        }

        public bool StokAlaniExist(int stokAlaniId)
        {
            return _context.StokAlanis.Any(s => s.Id == stokAlaniId);
        }
    }
}
