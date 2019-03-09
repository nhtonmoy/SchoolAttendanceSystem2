using Core.Data.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class FactoryDB
    {        public static Entities GetDB()
        {
            return new Entities();
        }
    }
}
