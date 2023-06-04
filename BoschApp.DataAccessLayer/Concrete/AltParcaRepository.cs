using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class AltParcaRepository : IAltParcaRepository
    {
        private readonly DataContext _context;

        public AltParcaRepository(DataContext context)
        {
            _context = context;
        }

        public bool AltParcaExist(int altParcaId)
        {
            throw new NotImplementedException();
        }

        public AltParca GetAltParca(int altParcaId)
        {
            throw new NotImplementedException();
        }

        public ICollection<AltParca> GetAltParcas()
        {
            throw new NotImplementedException();
        }

        public Istasyon GetIstasyonByAltParca(int altParcaId)
        {
            throw new NotImplementedException();
        }

        public StokAlani GetStokAlaniByAltParca(int altParcaId)
        {
            throw new NotImplementedException();
        }
    }
}
