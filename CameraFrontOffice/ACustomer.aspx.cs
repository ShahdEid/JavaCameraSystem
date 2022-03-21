using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class ACustomer : System.Web.UI.Page
{

    //var to store the pk with the page level scope
    Int32 CustomerID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the no of customers to be processed
        CustomerID = Convert.ToInt32(Session["CustomerID"]);
        if (IsPostBack == false)
        {
            //populate list of csuteomers
            DisplayCustomers();
            //if this is not a nw record
            if (CustomerID != -1)
            {
                //display current data for the record 
                DisplayCustomers();
            }
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        /*   //create a new instance of clsCustomer
           clsCustomer ACustomer = new clsCustomer();
           //capture LName
           string CustomerLName = txtLastName.Text;
           //capture FName
           string CustomerFName = txtFirstName.Text;
           //capture dob
           string CustomerDOB = txtDOB.Text;
           //capture phone no
           string CustomerPhoneNumber = txtPhoneNumber.Text;
           //capture post code
           string CustomerPostCode = txtPostCode.Text;
           //capture payment
           string CustomerPaymentInfo = DropDownPayment.Text;
           //variable to store error messages 
           string Error = "";
           //validate data
           Error = ACustomer.Valid(CustomerLName, CustomerFName, CustomerDOB, CustomerPaymentInfo, CustomerPhoneNumber, CustomerPostCode);
           if (Error == "")
           {
               //capture LName
               ACustomer.CustomerLName = CustomerLName;
               //capture FName
               ACustomer.CustomerFName = CustomerFName;
               //capture dob
               ACustomer.CustomerDOB = Convert.ToDateTime(CustomerDOB);
               //capture phone no
               ACustomer.CustomerPhoneNumber = CustomerPhoneNumber;
               //capture post code
               ACustomer.CustomerPostCode = CustomerPostCode;
               //capture payment
               ACustomer.CustomerPaymentInfo = CustomerPaymentInfo;
               //store the customer in the session object
               Session["ACustomer"] = ACustomer;
               //redirect to the viewer page
               Response.Redirect("CustomerViewer.aspx");
           }
           else
           {
               //display error
               lblError.Text = Error;
           }
           */

        if (CustomerID == -1)
        {
            //add new record
            Add();
        }
        else
        {
            //update 
            Update();
        }

        //all done redirect to the main page
        //  Response.Redirect("CustomerDefault.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsCustomer ACustomer = new clsCustomer();
        //Variable to store the pk
        Int32 ID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //get the pk entered by the user
        ID = Convert.ToInt32(txtID.Text);
        //Find the record
        Found = ACustomer.Find(ID);
        //If found
        if (Found == true)
        {
            //display the values of the p[roperties in the form
            txtFirstName.Text = ACustomer.CustomerFName;
            txtLastName.Text = ACustomer.CustomerLName;
            txtDOB.Text = ACustomer.CustomerDOB.ToString();
            txtPhoneNumber.Text = ACustomer.CustomerPhoneNumber;
            txtPostCode.Text = ACustomer.CustomerPostCode;
            DropDownPayment.Text = ACustomer.CustomerPaymentInfo;


        }


    }



    //function for adding new records
    void Add()
    {
        //create an instance of the customer 
        CameraClasses.clsCustomerCollection Customers = new CameraClasses.clsCustomerCollection();
        //validate the data on the web form
        String Error = Customers.ThisCustomer.Valid(txtDOB.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtPostCode.Text, DropDownPayment.Text);
        //if data isOK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Customers.ThisCustomer.CustomerDOB = Convert.ToDateTime(txtDOB.Text);
            Customers.ThisCustomer.CustomerFName = txtFirstName.Text;
            Customers.ThisCustomer.CustomerLName = txtLastName.Text;
            Customers.ThisCustomer.CustomerPhoneNumber = txtPhoneNumber.Text;
            Customers.ThisCustomer.CustomerPostCode = txtPostCode.Text;
            Customers.ThisCustomer.CustomerPaymentInfo = DropDownPayment.Text;
            //add the record
            Customers.Add();
            //all done redirect 
            Response.Redirect("CustomerDefault.aspx");

        }

        else
        {
            //error
            lblError.Text = "Something went wrong with the data entered" + Error;
        }
    }


    //function for updating records
    void Update()
    {
        //create n instance
        CameraClasses.clsCustomerCollection Customers = new CameraClasses.clsCustomerCollection();
        //validate data on the web form
        String Error = Customers.ThisCustomer.Valid(txtDOB.Text, txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text, txtPostCode.Text, DropDownPayment.Text);
        //if the data is OK add it to the object
        if (Error == "")
        {
            //find record to update
            Customers.ThisCustomer.Find(CustomerID);
            //get data entered by the user
            Customers.ThisCustomer.CustomerDOB = Convert.ToDateTime(txtDOB.Text);
            Customers.ThisCustomer.CustomerFName = txtFirstName.Text;
            Customers.ThisCustomer.CustomerLName = txtLastName.Text;
            Customers.ThisCustomer.CustomerPhoneNumber = txtPhoneNumber.Text;
            Customers.ThisCustomer.CustomerPostCode = txtPostCode.Text;
            Customers.ThisCustomer.CustomerPaymentInfo = DropDownPayment.Text;
            //update
            Customers.Update();
            //back to the main page
            Response.Redirect("CustomerDefault.aspx");

        }
        else
        {
            //error
            lblError.Text = "Something went wrong!" + Error;
        }
    }

    void DisplayCustomers()
    {
        //    //create an instance 
        clsCustomerCollection Customer = new clsCustomerCollection();
        //    //find the record to update
        Customer.ThisCustomer.Find(CustomerID);
        //    //display data for this record
        txtFirstName.Text = Customer.ThisCustomer.CustomerFName;
        txtLastName.Text = Customer.ThisCustomer.CustomerLName;
        txtDOB.Text = Customer.ThisCustomer.CustomerDOB.ToString();
        txtPhoneNumber.Text = Customer.ThisCustomer.CustomerPhoneNumber;
        txtPostCode.Text = Customer.ThisCustomer.CustomerPostCode;
        DropDownPayment.SelectedValue = Customer.ThisCustomer.CustomerPaymentInfo;
    }



  
}

