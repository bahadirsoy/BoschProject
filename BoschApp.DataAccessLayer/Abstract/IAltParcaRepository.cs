using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IAltParcaRepository
    {
        ICollection<AltParca> GetAltParcas();
        bool AltParcaExist(int altParcaId);
        AltParca GetAltParca(int altParcaId);
        StokAlani GetStokAlaniByAltParca(int altParcaId);
        Istasyon GetIstasyonByAltParca(int altParcaId);
        bool UpdateAltParca(AltParca altParca);
        bool Save();
    }
}
