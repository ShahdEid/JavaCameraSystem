using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Camera_Testing;
using CameraClasses;

public partial class JavaStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //cretae an instance of clsStaff
        clsStaff JavaStaff = new clsStaff();
        //get the data from the session objec
        JavaStaff = (clsStaff)Session["JavaStaff"];
        //display the house number for this entry
        Response.Write(JavaStaff.StaffID);
        
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //An instamce og clsStaff
        clsStaff JavaStaff = new clsStaff();
        //capture the houuse No
      //  JavaStaff.StaffID = txtStaffID.Text;
            //store the houseNo in the session object
            Session["JavaStaff"] = JavaStaff;
        //redirect to the viewer page
        Response.Redirect("JavaStaff.aspx");
        
    }



    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the customer class
        clsStaff JavaStaff = new clsStaff();
        //Variable to store the pk
        Int32 StaffID;
        //Variable to store the result of the find operation
        Boolean Found = false;
        //get the pk entered by the user
        StaffID = Convert.ToInt32(txtStaffID.Text);
        //Find the record
        Found = JavaStaff.Find(StaffID);
        //If found
        if (Found == true)
        {
           
            //display the values of the p[roperties in the form
            txtStaffName.Text = JavaStaff.StaffName;
            txtStaffDOB.Text = JavaStaff.DOB.ToString();
            txtPhoneNo.Text = JavaStaff.StaffPhoneNo;
            txtPostCode.Text = JavaStaff.PostCode;
            txtHouseNo.Text = JavaStaff.HouseNo;
            txtStreetName.Text = JavaStaff.Street;


        }

    }
}