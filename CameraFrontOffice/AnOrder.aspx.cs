using CameraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }











    protected void btnSave_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsOrder
        clsOrder AnOrder = new clsOrder();
        //caputure the quantity 
        AnOrder.Quantity=txtQuantity.Text;
        //store the order id in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }

   
}