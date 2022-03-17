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
        /*//create an instance of the clsStock
        clsStock MyStock = new clsStock();
        //get the data from the session object
        MyStock = (clsStock)Session["MyStock"];
        //display the stock name for this entry
        Response.Write(MyStock.StockName);*/
        //if this is the first time the page is displayed
        if(IsPostBack == false)
        {
            //update the list box
            DisplayStock();
        }
    }

    void DisplayStock()
    {
        //create an instance of the clsStockCollection
        clsStockCollection Stock = new clsStockCollection();
        //set the data source to the list of stock in the collection
        lstStock.DataSource = Stock.StockList;
        //set the name of the primary key
        lstStock.DataValueField = "StockId";
        //set the data field to display
        lstStock.DataTextField = "StockName";
        //bind the data to the list
        lstStock.DataBind();
    }
}