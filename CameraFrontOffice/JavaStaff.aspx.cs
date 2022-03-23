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
        //creating an instance of the clsStaff
        clsStaff JavaStaff = new clsStaff();
        //capture the staffId
        string  StaffID = txtStaffID.Text;
        //capture the sataff name
        string StaffName = txtStaffName.Text;
        //capture the staff dob
        string  StaffDOB = txtStaffDOB.Text;
        //capture the staff phone ni
        string StaffPhoneNo = txtStaffPhoneNo.Text;
        //capture the house no
        string StaffHouseNo = txtStaffHouseNo.Text;
        //capture the postcode
        string StaffPostCode = txtStaffPostCode.Text;
        //capture the street name
        string StaffStreet = txtStaffStreet.Text ;
        //capture the date added
        string  DateAdded = txtDateAdded.Text ;

        //variable to store any error
        string Error = "";
        //validate the data
        Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);

        if (Error == "")
        {
            //capture the staffId
            JavaStaff.StaffID = StaffID;
            //capture the sataff name
            JavaStaff.StaffName = StaffName;
            //capture the staff dob
            JavaStaff.DOB = StaffDOB;
            //capture the staff phone ni
            JavaStaff.StaffPhoneNo = StaffPhoneNo;
            //capture the house no
            JavaStaff.StaffHouseNo = StaffHouseNo;
            //capture the postcode
            JavaStaff.StaffPostCode = StaffPostCode;
            //capture the street name
            JavaStaff.StaffStreet = StaffStreet;
            //capture the date added
            JavaStaff.DateAdded = DateAdded;
        }

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
            txtStaffPhoneNo.Text = JavaStaff.StaffPhoneNo.ToString();
            txtStaffPostCode.Text = JavaStaff.StaffPostCode;
            txtStaffHouseNo.Text = JavaStaff.StaffHouseNo;
            txtStaffStreet.Text = JavaStaff.StaffStreet;


        }

    }
}