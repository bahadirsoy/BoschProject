using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
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
            throw new NotImplementedException();
        }

        public ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }

        public Enjektor GetEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Enjektor> GetEnjektors()
        {
            throw new NotImplementedException();
        }

        public Kisim GetKisimByEnjektor(int enjektorId)
        {
            throw new NotImplementedException();
        }
    }
}
