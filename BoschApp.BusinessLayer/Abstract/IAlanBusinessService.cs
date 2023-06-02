using BoschApp.EntityLayer.Entities.AlanEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IAlanBusinessService
    {
        ICollection<Alan> GetAlans();
    }
}
