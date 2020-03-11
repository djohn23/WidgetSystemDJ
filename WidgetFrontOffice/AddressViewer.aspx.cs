using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgetClasses;

public partial class AddressViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
            //create a new instance of clsAddress
            clsAddress AnAddress = new clsAddress();
            //get the data from the the session object
            AnAddress = (clsAddress)Session["AnAddress"];
            //display the house number for this entry
            Response.Write(AnAddress.HouseNo);
        Response.Write(AnAddress.HouseNo);
        Response.Write(AnAddress.Street);
        Response.Write(AnAddress.Town);
        Response.Write(AnAddress.PostCode);
        Response.Write(AnAddress.County);
        Response.Write(AnAddress.DateAdded);

    }
}