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
    public partial class index : System.Web.UI.Page
    {
        private PaisesBOL paisBOL = new PaisesBOL();
        protected void Page_Load(object sender, EventArgs e)
        {
            Test_Insert();
        }
        
        public void Test_Insert()
        {
            string nombre = "Argentina";
            PaisesDTO paisDTO = new PaisesDTO();
            paisDTO.paisnombre = nombre;
            try
            {
                paisBOL.Insert(paisDTO);
                lblResultado.Text = "Registro insertado Correctamente";
            }
            catch (Exception ex)
            {
                lblResultado.Text = ex.Message;
                
            }
               
        }
    
    
    }

}