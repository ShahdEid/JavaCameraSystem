﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class CustomerDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
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
}