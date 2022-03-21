using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class CustomerDefault : System.Web.UI.Page
{
    //var to store the pk with pagelevel scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the no of the customer to be processed
        //CustomerID = Convert.ToInt32(Session["CustomerID"]);
        //if this is the first time the page is diplayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        //create an instance of the customercollection
        CameraClasses.clsCustomerCollection Customers = new CameraClasses.clsCustomerCollection();
        //set data source to the list of customers in the collection
        lstCustomers.DataSource = Customers.CustomerList;
        //set the name of the pk
        lstCustomers.DataValueField = "CustomerID";
        //set the data field to display
        lstCustomers.DataTextField = "CustomerFName";
        //bind the data to the list
        lstCustomers.DataBind();

    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["CustomerID"] = -1;
        //redirect tpo the entry page
        Response.Redirect("ACustomer.aspx");
    }


    //event handler for ze delete btn
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the pk value of the record to be delted
        Int32 CustomerID;
        //if a record has ben selected from the list
        if (lstCustomers.SelectedIndex != -1)
        {
            //get pk value of the record to delete 
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //redirect to the delete page
            Response.Redirect("CustomerDelete.aspx");
        }
        else
        {
            //error
            lblError.Text = "You have to select a record to delete from the list above";
        }
    }



    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //var to store pk value of the record to be edited
        Int32 CustomerID;
        //if sa record has been selected from the list
        if (lstCustomers.SelectedIndex != 1)
        {
            //get the pk value of the record to edit
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            //store the data in the session object
            Session["CustomerID"] = CustomerID;
            //Redirect to edit page
            Response.Redirect("ACustomer.aspx");
        }
        //no record has been selected
        else
        {
            //error
            lblError.Text = "You have to select a record to edit from the list";
        }
    }


}