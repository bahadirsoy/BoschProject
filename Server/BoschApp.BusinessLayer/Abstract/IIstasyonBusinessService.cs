using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IIstasyonBusinessService
    {
        ICollection<Istasyon> GetIstasyons();
        Istasyon GetIstasyon(int istasyonId);
        ICollection<AltParca> GetAltParcasByIstasyon(int istasyonId);
    }
}
