﻿using BoschApp.EntityLayer.Entities.AlanEntity;
using BoschApp.EntityLayer.Entities.DepartmanEntityEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IAlanRepository
    {
        ICollection<Alan> GetAlans();
        Alan GetAlan(int alanId);
        bool AlanExist(int alanId);
        ICollection<Departman> GetDepartmansByAlan(int alanId);
    }
}
