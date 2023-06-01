using BoschApp.EntityLayer.Entities.AlanEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.EntityLayer.Entities.DepartmanEntityEntity
{
    public class Departman
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public float Butce { get; set; }
        public Alan Alan { get; set; }
    }
}
