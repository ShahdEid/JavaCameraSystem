using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class MyStockView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create an instance of the clsStock
        clsStock MyStock = new clsStock();
        //get the data from the session object
        MyStock = (clsStock)Session["MyStock"];
        //display the stock name for this entry
        Response.Write(MyStock.StockName);
    }
}