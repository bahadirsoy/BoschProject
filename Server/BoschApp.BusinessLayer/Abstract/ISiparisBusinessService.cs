using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface ISiparisBusinessService
    {
        ICollection<Siparis> GetSiparises();
        Siparis GetSiparis(int siparisId);
        Enjektor GetEnjektorBySiparis(int siparisId);
        ICollection<Uretim> GetUretimsBySiparis(int siparisId);
        ICollection<Siparis> GetSiparisAndEnjektor(int siparisId);
        bool CreateSiparis(Siparis siparis);
        bool UpdateSiparis(Siparis siparis, int siparisId);
    }
}
