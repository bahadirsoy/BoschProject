using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.KisimEntity
{
    public class Kisim
    {
        public int Id { get; set; }
        public string KisimNo { get; set; }
        public Departman Departman { get; set; }
        public ICollection<Enjektor> Enjektors { get; set; }
    }
}
