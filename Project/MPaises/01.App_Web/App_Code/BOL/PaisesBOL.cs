using _01.App_Web.App_Code.BOL.Core;
using _01.App_Web.App_Code.DAL;
using _01.App_Web.App_Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.App_Web.App_Code.BOL
{
    public class PaisesBOL
    {
        private PaisesDAL paisDAL = new PaisesDAL();
        public void Insert(PaisesDTO paisDTO)
        {
            Paises pais = new Paises(paisDTO.paisId, paisDTO.paisnombre);
            paisDAL.Insert(pais);
             
        }

    }
}