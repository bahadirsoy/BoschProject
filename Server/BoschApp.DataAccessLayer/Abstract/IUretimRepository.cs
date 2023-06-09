﻿using BoschApp.EntityLayer.Entities.AltParcaEntity;
using BoschApp.EntityLayer.Entities.SiparisEntity;
using BoschApp.EntityLayer.Entities.UretimEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.DataAccessLayer.Abstract
{
    public interface IUretimRepository
    {
        Uretim GetUretim(int uretimId);
        bool UretimExist(int uretimId);
        Siparis GetSiparisByUretim(int uretimId);
        AltParca GetAltParcaByUretim(int uretimId);
        bool IsProduced(int siparisId, int altParcaId);
        bool CreateUretim(Uretim uretim);
        bool DeleteUretim(Uretim uretim);
        bool Save();
    }
}
