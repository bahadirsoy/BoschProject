using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoschApp.BusinessLayer.Rules
{
    public class BusinessRules
    {
        public bool IsNull(Object o)
        {
            return o == null;
        }
    }
}
