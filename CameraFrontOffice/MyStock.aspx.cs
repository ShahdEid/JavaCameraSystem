using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;


public partial class MyStock : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 StockId;

    //event handler for the page load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be processed
        StockId = Convert.ToInt32(Session["StockId"]);
        if(IsPostBack == false)
        {
            //if this is not a new record
            if(StockId != -1)
            {
                //display the current data for the record
                DisplayStock();
            }
        }
    }
    
    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StockId == -1)
        {
            //add the new record
            Add();
        }
        else
        {
            //update the record
            Update();
        }
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
            txtStockPrice.Text = MyStock.StockPrice.ToString();
            txtStockQuantity.Text = MyStock.StockQuantity.ToString();
            txtDateAdded.Text = MyStock.DateAdded.ToString();
        }
    }

    //function for adding new records
    void Add()
    {
        //create an instance of the clsStockCollection
        clsStockCollection AStock = new clsStockCollection();
        //validate the data on the web form
        String Error = AStock.ThisStock.Valid(txtStockName.Text, txtStockType.Text, txtStockPrice.Text, txtStockQuantity.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            AStock.ThisStock.StockName = txtStockName.Text;
            AStock.ThisStock.StockType = txtStockType.Text;
            AStock.ThisStock.StockPrice = Convert.ToDecimal(txtStockPrice.Text);
            AStock.ThisStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            AStock.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //add the record
            AStock.Add();
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    //function for updating records
    void Update()
    {
        //create an instance of the clsStockCollection
        clsStockCollection AStock = new clsStockCollection();
        //validate the data on the web form
        String Error = AStock.ThisStock.Valid(txtStockName.Text, txtStockType.Text, txtStockPrice.Text, txtStockQuantity.Text, txtDateAdded.Text);
        //if the data is OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            AStock.ThisStock.Find(StockId);
            //get the data entered by the user
            AStock.ThisStock.StockName = txtStockName.Text;
            AStock.ThisStock.StockType = txtStockType.Text;
            AStock.ThisStock.StockPrice = Convert.ToDecimal(txtStockPrice.Text);
            AStock.ThisStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
            AStock.ThisStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            //update the record
            AStock.Update();
            //all done so redirect to the main page
            Response.Redirect("MyStockView.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There were problems with the data entered " + Error;
        }
    }

    void DisplayStock()
    {
        //create an instance of the clsStockCollection
        clsStockCollection AStock = new clsStockCollection();
        //find the record to update
        AStock.ThisStock.Find(StockId);
        //display the data for this record
        txtStockName.Text = AStock.ThisStock.StockName;
        txtStockType.Text = AStock.ThisStock.StockType;
        txtStockPrice.Text = AStock.ThisStock.StockPrice.ToString();
        txtStockQuantity.Text = AStock.ThisStock.StockQuantity.ToString();
        txtDateAdded.Text = AStock.ThisStock.DateAdded.ToString();
    }
}