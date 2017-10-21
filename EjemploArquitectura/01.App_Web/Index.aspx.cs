using _01.App_Web.App_Code.BOL;
using _01.App_Web.App_Code.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.App_Web
{
    public partial class Index : System.Web.UI.Page
    {
        private PaisesBOL paisBOL = new PaisesBOL();
        protected void Page_Load(object sender, EventArgs e)
        {
            TEST_GETALL();
        }

        public void TEST_insert()
        {
            string nombre = "brasil";
            PaisesDTO paisDTO = new PaisesDTO();
            paisDTO.paisNombre = nombre;
            try
            {
                paisBOL.Insert(paisDTO);
                lblResultado.Text = "Registro insertado correctamente";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }   
        }
        public void TEST_GET()
        {
            int id = 2;
            PaisesDTO paisDTO = new PaisesDTO();

            paisDTO.paisId = id;
            try
            {
                PaisesDTO resultadoDTO = paisBOL.Get(paisDTO);

                lblResultado.Text = String.Format("El nombre del pais con id {0} es : {1}", resultadoDTO.paisId, resultadoDTO.paisNombre);
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
            }
            

        }

        public void TEST_GETALL()
        {
            try
            {
                GridView1.DataSource = paisBOL.GetAll();
                GridView1.DataBind();
                lblResultado.Text = "Esta es la lista de paises";
            }
            catch (Exception ex)
            {

                lblResultado.Text = ex.Message;
            }
        }
    }
}