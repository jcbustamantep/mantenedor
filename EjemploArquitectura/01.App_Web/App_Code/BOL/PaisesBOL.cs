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
        // Resivir los objetos DTO tranformalos a Objetos de negocio y ejecutar los metodos de negocio que tenga nuestra identidad
        // 
        private PaisesDAL paisDAL = new PaisesDAL();
        public void Insert(PaisesDTO PaisDTO)
        {
            Paises pais = new Paises (PaisDTO.paisNombre);
            paisDAL.Insert(pais);
        }

        public PaisesDTO Get (PaisesDTO paisDTO)
        {
            Paises pais = new Paises (paisDTO.paisNombre);

            Paises nuevoPais = paisDAL.Get(pais);

            PaisesDTO nuevoPaisDTO = new PaisesDTO() { paisId = nuevoPais.PaisId , paisNombre = nuevoPais.PaisNombre };

            return nuevoPaisDTO;
        }
        public List<PaisesDTO> GetAll ()
        {

            List<PaisesDTO> miLista = new List<PaisesDTO>();

            foreach (Paises pais in paisDAL.GetAll()) 
            {
                PaisesDTO nuevoPaisDTO = new PaisesDTO();

                nuevoPaisDTO.paisId = pais.PaisId;
                nuevoPaisDTO.paisNombre = pais.PaisNombre;

                miLista.Add (nuevoPaisDTO);
            }

            return miLista;
        }

        public void Update(PaisesDTO paisDTO)
        {
            PaisesDTO nuevoPaisDTO = Get(paisDTO);
            Paises pais = new Paises(nuevoPaisDTO.paisNombre);
            pais.PaisNombre = paisDTO.paisNombre;

            paisDAL.Update(pais);
        }
    }
}