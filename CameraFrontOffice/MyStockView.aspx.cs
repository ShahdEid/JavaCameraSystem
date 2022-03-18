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

    //event handler for the add button
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockId"] = -1;
        //redirect to the data entry page
        Response.Redirect("MyStock.aspx");
    }

    //event handler for the delete button
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StockId;
        //if a record has been selected from the list
        if(lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockId = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the delete page
            Response.Redirect("MyStockDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    //event handler for the edit button
    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StockId;
        //if a record has been selected from the list
        if(lstStock.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockId = Convert.ToInt32(lstStock.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the edit page
            Response.Redirect("MyStock.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}