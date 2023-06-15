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
        Uretim GetUretim(int uretimId);
        Siparis GetSiparisByUretim(int uretimId);
        AltParca GetAltParcaByUretim(int uretimId);
        bool IsProduced(int siparisId, int altParcaId);
        bool CreateUretim(Uretim uretim, int siparisId, int altParcaId);
        bool DeleteUretim(Uretim uretim, int uretimId);
    }
}
