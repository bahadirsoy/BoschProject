using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
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

        public AltParca GetAltParcaByUretim(int uretimId)
        {
            throw new NotImplementedException();
        }

        public Siparis GetSiparisByUretim(int uretimId)
        {
            throw new NotImplementedException();
        }

        public bool UretimExist(int uretimId)
        {
            throw new NotImplementedException();
        }
    }
}
