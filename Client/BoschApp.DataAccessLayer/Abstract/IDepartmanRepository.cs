using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IDepartmanRepository
    {
        ICollection<Departman> GetDepartmans();
        bool DepartmanExist(int departmanId);
        Departman GetDepartman(int departmanId);
        Alan GetAlanByDepartman(int departmanId);
        ICollection<Kisim> GetKisimsByDepartman(int departmanId);
    }
}
