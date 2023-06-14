using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IEnjektorRepository
    {
        ICollection<Enjektor> GetEnjektors();
        bool EnjektorExist(int enjektorId);
        Enjektor GetEnjektor(int enjektorId);
        Kisim GetKisimByEnjektor(int enjektorId);
        ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId);
        AltParca GetAltParcaByEnjektorAndIstasyon(int enjektorId, int istasyonId);
    }
}
