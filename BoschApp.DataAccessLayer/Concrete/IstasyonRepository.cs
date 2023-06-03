using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
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

        public ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId)
        {
            throw new NotImplementedException();
        }

        public Istasyon GetIstasyon(int istasyonId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Istasyon> GetIstasyons()
        {
            throw new NotImplementedException();
        }

        public bool IstasyonExist(int istasyonId)
        {
            throw new NotImplementedException();
        }
    }
}
