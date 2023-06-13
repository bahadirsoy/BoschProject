using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface ISiparisRepository
    {
        ICollection<Siparis> GetSiparises();
        bool SiparisExist(int siparisId);
        Siparis GetSiparis(int siparisId);
        Enjektor GetEnjektorBySiparis(int siparisId);
        ICollection<Uretim> GetUretimsBySiparis(int siparisId);
        ICollection<Siparis> GetSiparisAndEnjektors();
        bool CreateSiparis(Siparis siparis);
        bool UpdateSiparis(Siparis siparis);
        bool Save();
    }
}
