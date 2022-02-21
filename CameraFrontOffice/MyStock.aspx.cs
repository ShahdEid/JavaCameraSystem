using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;


public partial class MyStock : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create an instance of clsStock
        clsStock MyStock = new clsStock();
        //capture the Stock Name
        MyStock.StockName = txtStockName.Text;
        //store the stock in the session object
        Session["MyStock"] = MyStock;
        //redirect to the viewer page
        Response.Redirect("MyStockView.aspx");
    }
}