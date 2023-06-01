using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.SiparisEntity
{
    public class Siparis
    {
        public int Id { get; set; }
        public int Adet { get; set; }
        public int SiparisDurumu { get; set; }
        public Enjektor Enjektor { get; set; }
        public ICollection<Uretim> Uretims { get; set; }
    }
}
