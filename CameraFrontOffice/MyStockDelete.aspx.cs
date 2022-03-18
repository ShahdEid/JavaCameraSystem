using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class MyStockDelete : System.Web.UI.Page
{
    //var to store the primary key value of the record to be deleted
    Int32 StockId;

    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be deleted from the session object
        StockId = Convert.ToInt32(Session[StockId]);
    }

    //function to delete the selected record
    void DeleteStock()
    {
        //create a new instance of the clsStockCollection
        clsStockCollection MyStock = new clsStockCollection();
        //find the record to be deleted
        MyStock.ThisStock.Find(StockId);
        //delete the record
        MyStock.Delete();
    }

    //event handler for the yes button
    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delete the record
        DeleteStock();
        //redirect back to the main page
        Response.Redirect("MyStockView.aspx");
    }
}