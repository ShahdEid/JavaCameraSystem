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

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the stock class
        clsStock MyStock = new clsStock();
        //variable to store the primary key
        Int32 StockId;
        //variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StockId = Convert.ToInt32(txtStockId.Text);
        //find the record
        Found = MyStock.Find(StockId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtStockName.Text = MyStock.StockName;
            txtStockType.Text = MyStock.StockType;
            txtStockQuantity.Text = MyStock.StockQuantity.ToString();
            txtDateAdded.Text = MyStock.DateAdded.ToString();
        }
    }
}