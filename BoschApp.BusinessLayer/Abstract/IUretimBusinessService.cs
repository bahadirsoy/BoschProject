using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IUretimBusinessService
    {
        Siparis GetSiparisByUretim(int uretimId);
        AltParca GetAltParcaByUretim(int uretimId);
        bool CreateSiparis(Uretim uretim);
    }
}
