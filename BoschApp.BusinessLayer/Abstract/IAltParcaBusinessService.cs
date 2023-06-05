using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IAltParcaBusinessService
    {
        ICollection<AltParca> GetAltParcas();
        AltParca GetAltParca(int altParcaId);
        StokAlani GetStokAlaniByAltParca(int altParcaId);
        Istasyon GetIstasyonByAltParca(int altParcaId);
        bool UpdateAltParca(AltParca altParca, int altParcaId);
    }
}
