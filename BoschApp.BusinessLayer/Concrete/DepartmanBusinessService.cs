using BoschApp.BusinessLayer.Abstract;
using BoschApp.BusinessLayer.Rules;
using BoschApp.DataAccessLayer.Abstract;
using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Concrete
{
    public class DepartmanBusinessService : IDepartmanBusinessService
    {
        private readonly IDepartmanRepository _departmanRepository;
        private readonly BusinessRules _rules;

        public DepartmanBusinessService(IDepartmanRepository departmanRepository, BusinessRules rules)
        {
            _departmanRepository = departmanRepository;
            _rules = rules;
        }
        public Alan GetAlanByDepartman(int departmanId)
        {
            throw new NotImplementedException();
        }

        public Departman GetDepartman(int departmanId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Departman> GetDepartmans()
        {
            throw new NotImplementedException();
        }

        public ICollection<Kisim> GetKisimsByDepartman(int departmanId)
        {
            throw new NotImplementedException();
        }
    }
}
