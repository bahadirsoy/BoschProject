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
            return _context.AltParcas.Any(a => a.Id == altParcaId);
        }

        public AltParca GetAltParca(int altParcaId)
        {
            return _context.AltParcas.Where(a => a.Id == altParcaId).FirstOrDefault();
        }

        public ICollection<AltParca> GetAltParcas()
        {
            return _context.AltParcas.ToList();
        }

        public Istasyon GetIstasyonByAltParca(int altParcaId)
        {
            return _context.AltParcas.Where(a => a.Id == altParcaId).Select(a => a.Istasyon).FirstOrDefault();
        }

        public StokAlani GetStokAlaniByAltParca(int altParcaId)
        {
            return _context.StokAlanis.Where(s => s.AltParca.Id == altParcaId).FirstOrDefault();
        }
    }
}
