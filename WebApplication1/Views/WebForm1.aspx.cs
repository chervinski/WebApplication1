using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.Controllers;

namespace WebApplication1.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Click(object sender, EventArgs e)
        {
            try
            {
                ShopController.AddProduct(nameTextBox.Text, int.Parse(countTextBox.Text));
            }
            catch (Exception ex) { 
            
            }
        }
    }
}