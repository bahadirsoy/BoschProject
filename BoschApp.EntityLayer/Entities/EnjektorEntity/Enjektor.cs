using BoschApp.EntityLayer.Entities.KisimEntity;
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
    }
}
