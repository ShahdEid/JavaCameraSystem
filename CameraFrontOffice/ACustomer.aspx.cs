using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;

public partial class ACustomer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.CustomerLName = txtFirstName.Text;
        //store the customer in the session object
        Session["ACustomer"] = ACustomer;
        //redirect to the viewer page
        Response.Redirect("CustomerViewer.aspx");
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
}