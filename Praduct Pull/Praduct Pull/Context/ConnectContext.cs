using Praduct_Pull.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praduct_Pull.Context
{
    public class ConnectContext
    {
        public static dbProdEntities db = new dbProdEntities();
    }
}
