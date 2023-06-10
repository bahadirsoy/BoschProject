using BoschApp.EntityLayer.Entities.AltParcaEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.IstasyonEntity
{
    public class Istasyon
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public ICollection<AltParca> AltParcas { get; set; }
    }
}
