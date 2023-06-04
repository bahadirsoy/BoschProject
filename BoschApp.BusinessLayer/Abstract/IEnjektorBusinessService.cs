using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IEnjektorBusinessService
    {
        ICollection<Enjektor> GetEnjektors();
        Enjektor GetEnjektor(int enjektorId);
        Kisim GetKisimByEnjektor(int enjektorId);
        ICollection<AltParca> GetAltParcasByEnjektor(int enjektorId);
    }
}
