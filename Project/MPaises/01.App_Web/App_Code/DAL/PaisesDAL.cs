using _01.App_Web.App_Code.BOL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.App_Web.App_Code.DAL
{
    public class PaisesDAL
    {
        private PetaPoco.Database db = new PetaPoco.Database("basepais");
        public void Insert (Paises pais)
        {
            db.Insert(pais);
        }

      
    }
}