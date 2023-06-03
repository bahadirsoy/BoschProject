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
            throw new NotImplementedException();
        }

        public ICollection<Enjektor> GetEnjektorsByKisim(int kisimId)
        {
            throw new NotImplementedException();
        }

        public Kisim GetKisim(int kisimId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Kisim> GetKisims()
        {
            throw new NotImplementedException();
        }

        public bool KisimExist(int kisimId)
        {
            throw new NotImplementedException();
        }
    }
}
