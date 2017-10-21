﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01.App_Web.App_Code.BOL.Core
{
    [PetaPoco.TableName("PAISES")]
    [PetaPoco.PrimaryKey("paisId")]
    public class Paises
    {
        #region Atributos

        private int _paisId;

        public int paisId
        {
            get { return _paisId; }
            private set { _paisId = value; }
        }
                
        private string _paisNombre;

        public string paisNombre
        {
            get { return _paisNombre; }
            private set { _paisNombre = value; }
        }
        


        #endregion 

        #region Metodos
        
        #endregion

        #region Contructores


        public Paises()
        {
        }

        public  Paises(int id, string nombre)
        {
            _paisId = id;
            _paisNombre = nombre;


        }




        #endregion
    }
}