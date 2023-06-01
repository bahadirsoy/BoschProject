using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.AlanEntity
{
    public class Alan
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public ICollection<Departman> departmans { get; set; }
    }
}
