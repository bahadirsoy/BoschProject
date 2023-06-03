using BoschApp.DataAccessLayer.Abstract;
using BoschApp.DataAccessLayer.Data;
using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using BoschApp.EntityLayer.Entities.KisimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Concrete
{
    public class DepartmanRepository : IDepartmanRepository
    {
        private readonly DataContext _context;

        public DepartmanRepository(DataContext context)
        {
            _context = context;
        }

        public bool DepartmanExist(int departmanId)
        {
            return _context.Departmants.Any(d => d.Id == departmanId);
        }

        public Alan GetAlanByDepartman(int departmanId)
        {
            return _context.Departmants.Where(d => d.Id == departmanId).Select(d => d.Alan).FirstOrDefault();
        }

        public Departman GetDepartman(int departmanId)
        {
            return _context.Departmants.Where(d => d.Id == departmanId).FirstOrDefault();
        }

        public ICollection<Departman> GetDepartmans()
        {
            return _context.Departmants.ToList();
        }

        public ICollection<Kisim> GetKisimsByDepartman(int departmanId)
        {
            return _context.Kisims.Where(k => k.Departman.Id == departmanId).ToList();
        }
    }
}
