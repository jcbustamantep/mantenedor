using _01.App_Web.App_Code.BOL.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.App_Web.App_Code.DAL
{
    public class PaisesDAL
    {
        private PetaPoco.Database db = new PetaPoco.Database("mibase");
        public void Insert (Paises pais)
        {
            db.Insert(pais);
        }

        public Paises Get(Paises pais)
        {
            return db.Single<Paises>(pais.paisId);
        }

        public IEnumerable<Paises> GetAll()
        {
            return db.Query<Paises>("SELECT paisId,paisNombre FROM PAISES");
        }
        public void Update(Paises pais)
        {
            db.Update(pais);
        }



    }

}