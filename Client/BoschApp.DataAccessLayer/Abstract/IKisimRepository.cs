using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.EnjektorEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IKisimRepository
    {
        ICollection<Kisim> GetKisims();
        bool KisimExist(int kisimId);
        Kisim GetKisim(int kisimId);
        Departman GetDepartmanByKisim(int kisimId);
        ICollection<Enjektor> GetEnjektorsByKisim(int kisimId);
    }
}
