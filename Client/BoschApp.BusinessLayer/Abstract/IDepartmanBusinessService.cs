using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Abstract
{
    public interface IDepartmanBusinessService
    {
        ICollection<Departman> GetDepartmans();
        Departman GetDepartman(int departmanId);
        Alan GetAlanByDepartman(int departmanId);
        ICollection<Kisim> GetKisimsByDepartman(int departmanId);
    }
}
