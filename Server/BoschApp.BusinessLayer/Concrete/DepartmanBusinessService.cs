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
            if(!_departmanRepository.DepartmanExist(departmanId))
            {
                throw new Exception("There is no departman with id: " + departmanId);
            }

            var alan = _departmanRepository.GetAlanByDepartman(departmanId);

            if (_rules.IsNull(alan))
            {
                throw new Exception("There is no such Alan");
            }

            return alan;
        }

        public Departman GetDepartman(int departmanId)
        {
            if (!_departmanRepository.DepartmanExist(departmanId))
            {
                throw new Exception("There is no departman with id: " + departmanId);
            }

            var departman = _departmanRepository.GetDepartman(departmanId);

            if (_rules.IsNull(departman))
            {
                throw new Exception("There is no such departman");
            }

            return departman;
        }

        public ICollection<Departman> GetDepartmans()
        {
            var departmans = _departmanRepository.GetDepartmans();

            if (_rules.IsNull(departmans))
            {
                throw new Exception("There is no departman");
            }

            return departmans;
        }

        public ICollection<Kisim> GetKisimsByDepartman(int departmanId)
        {
            if (!_departmanRepository.DepartmanExist(departmanId))
            {
                throw new Exception("There is no departman with id: " + departmanId);
            }

            var kisims = _departmanRepository.GetKisimsByDepartman(departmanId);

            if (_rules.IsNull(kisims))
            {
                throw new Exception("There is no kisim belonging to this departman");
            }

            return kisims;
        }
    }
}
