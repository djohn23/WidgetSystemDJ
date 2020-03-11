using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WidgetClasses;

public partial class AnAddress : System.Web.UI.Page
{
    protected void btnOK(object sender, EventArgs e)
    {
        //CREATE A NEW INSTANCE OF clsAddress
        clsAddress AnAddress = new clsAddress();
        //get data from session object
        AnAddress = (clsAddress)Session["AnAddress"];
        //display the hous enumber for this entry
        Response.Write(AnAddress.HouseNo);


    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create a new instance of clsAddress
        clsAddress AnAddress = new clsAddress();
        //capture the house number
        AnAddress.HouseNo = txtHouseNo.Text;
        //capture the street name
        AnAddress.Street = txtStreet.Text;
        //capture the Town
        AnAddress.Town = txtTown.Text;
        //capture the post code
        AnAddress.PostCode = txtPostCode.Text;
        //capture the county
        AnAddress.County = txtCounty.Text;
        // capture Date Added
        AnAddress.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        //store the address in the session object
        Session["AnAddress"] = AnAddress;
        //Redirect to the viewer page
        Response.Redirect("AddressViewer.aspx");

    }

  

}
