using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.EnjektorAltParcaEntity
{
    public class EnjektorAltParca
    {
        public int EnjektorId { get; set; }
        public int AltParcaId { get; set; }
        public Enjektor Enjektor { get; set; }
        public AltParca AltParca { get; set; }
    }
}
