using BoschApp.EntityLayer.Entities.SiparisEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.UretimEntity
{
    public class Uretim
    {
        public int Id { get; set; }
        public int UretimDurumu { get; set; }
        public Siparis Siparis { get; set; }
    }
}
