using BoschApp.EntityLayer.Entities.EnjektorAltParcaEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.EnjektorEntity
{
    public class Enjektor
    {
        public int Id { get; set; }
        public string Tur { get; set; }
        public string ModelNo { get; set; }
        public Kisim Kisim { get; set; }
        public ICollection<Siparis> Siparis { get; set; }
        public ICollection<EnjektorAltParca> EnjektorAltParcas { get; set; }
    }
}
