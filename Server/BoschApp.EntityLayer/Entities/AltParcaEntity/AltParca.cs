using BoschApp.EntityLayer.Entities.EnjektorAltParcaEntity;
using BoschApp.EntityLayer.Entities.IstasyonEntity;
using BoschApp.EntityLayer.Entities.StokAlaniEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.AltParcaEntity
{
    public class AltParca
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Masraf { get; set; }
        public ICollection<Uretim> Uretims { get; set; }
        public Istasyon Istasyon { get; set; }
        public ICollection<StokAlani> StokAlanis { get; set; }
        public ICollection<EnjektorAltParca> EnjektorAltParcas { get; set; }
    }
}
