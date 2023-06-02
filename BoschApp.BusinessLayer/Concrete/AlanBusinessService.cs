using BoschApp.BusinessLayer.Abstract;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AlanEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class AlanBusinessService : IAlanBusinessService
    {
        private readonly IAlanRepository _alanRepository;

        public AlanBusinessService(IAlanRepository alanRepository)
        {
            _alanRepository = alanRepository;
        }

        public ICollection<Alan> GetAlans()
        {
            return _alanRepository.GetAlans();
        }
    }
}
