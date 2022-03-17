using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class CustomerDelete : System.Web.UI.Page
{
    //var to store pk value of the record to be deleted
    Int32 CustomerID;
    //event handler for the load event
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the no of the customer to be deleted from the session object
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
    }
    void DeleteCustomer()
    {
        //function to delete the selected record

        //create a neew instance of custimer
        clsCustomerCollection Customers = new clsCustomerCollection();
        //find rge record to delete 
        Customers.ThisCustomer.Find(CustomerID);
        Customers.Delete();
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //delte record
        DeleteCustomer();
        //redirect back to the main page
        Response.Redirect("CustomerDefault.aspx");
    }
}