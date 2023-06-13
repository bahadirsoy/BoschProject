using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IIstasyonRepository
    {
        ICollection<Istasyon> GetIstasyons();
        bool IstasyonExist(int istasyonId);
        Istasyon GetIstasyon(int istasyonId);
        ICollection<AltParca> GetAltParcaAndStokAlaniByIstasyon(int istasyonId);
        ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId);
    }
}
