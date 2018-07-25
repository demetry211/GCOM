using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCOM.Data
{
    public class GComContext: DbContext
    {
        public GComContext():base("name=")
        {

        }


    }
}
