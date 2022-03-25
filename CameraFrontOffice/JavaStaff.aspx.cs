using System;
using Camera_Testing;

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
    /*
    void DisplayStaffs()
    {
        //creating an instance of the staff collection
        CameraClasses.clsStaffCollection JavaStaff = new CameraClasses.clsStaffCollection();
        //set the data source to the list of staff in the collection

        lstStaff.DataSource = JavaStaff.StaffList;
        //set the name of the primary key
        lstStaff.DataValueField = "StaffID";
        //set the data field to display
        lstStaff.DataTextField = "PostCode";
        //BIND THE DATA to the list 
        lstStaff.DataBind();
        
    }*/
    protected void btnOk_Click(object sender, EventArgs e)
    {

        //creating an instance of the clsStaff
        clsStaff JavaStaff = new clsStaff();
        //capture the staffId
        string StaffID = txtStaffID.Text;
        //capture the sataff name
        string StaffName = txtStaffName.Text;
        //capture the staff dob
        string StaffDOB = txtStaffDOB.Text;
        //capture the staff phone ni
        string StaffPhoneNo = txtStaffPhoneNo.Text;
        //capture the house no
        string StaffHouseNo = txtStaffHouseNo.Text;
        //capture the postcode
        string StaffPostCode = txtStaffPostCode.Text;
        //capture the street name
        string StaffStreet = txtStaffStreet.Text;
        //capture the date added
        string DateAdded = txtDateAdded.Text;

        //variable to store any error
        string Error = "";
        //validate the data
        Error = JavaStaff.Valid(StaffID, StaffName, StaffPhoneNo, StaffHouseNo, StaffStreet, StaffDOB, StaffPostCode, DateAdded);

        if (Error == "")
        {
            //capture the staffId
            // JavaStaff.StaffID = StaffID;
            //capture the sataff name
            JavaStaff.StaffName = StaffName;
            //capture the staff dob
            JavaStaff.StaffDOB = Convert.ToDateTime(StaffDOB);
            //capture the staff phone ni
            JavaStaff.StaffPhoneNo = StaffPhoneNo;
            //capture the house no
            JavaStaff.StaffHouseNo = StaffHouseNo;
            //capture the postcode
            JavaStaff.StaffPostCode = StaffPostCode;
            //capture the street name
            JavaStaff.StaffStreet = StaffStreet;
            //capture the date added
            JavaStaff.DateAdded = Convert.ToDateTime(DateAdded);
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
            txtStaffDOB.Text = JavaStaff.StaffDOB.ToString();
            txtStaffPhoneNo.Text = JavaStaff.StaffPhoneNo.ToString();
            txtStaffPostCode.Text = JavaStaff.StaffPostCode;
            txtStaffHouseNo.Text = JavaStaff.StaffHouseNo;
            txtStaffStreet.Text = JavaStaff.StaffStreet;


        }
    }
    //function for adding new records
    void Add()
    {
        //create an instance of the customer 
        CameraClasses.clsStaffCollection Staffs = new CameraClasses.clsStaffCollection();
        //validate the data on the web form
        String Error = Staffs.ThisStaff.Valid(txtStaffDOB.Text, txtStaffName.Text, txtStaffStreet.Text, txtStaffPhoneNo.Text, txtStaffPostCode.Text, txtStaffHouseNo.Text, txtDateAdded.Text);
        //if data isOK then add it to the object
        if (Error == "")
        {
            //get data entered by the user
            Staffs.ThisStaff.StaffDOB = Convert.ToDateTime(txtStaffDOB.Text);
            Staffs.ThisStaff.StaffName = txtStaffName.Text;
            Staffs.ThisStaff.StaffStreet = txtStaffStreet.Text;
            Staffs.ThisStaff.StaffPhoneNo = txtStaffPhoneNo.Text;
            Staffs.ThisStaff.StaffPostCode = txtStaffPostCode.Text;
            Staffs.ThisStaff.StaffHouseNo = txtStaffPostCode.Text;
            Staffs.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

            //add the record
            Staffs.Add();
            //all done redirect 
            Response.Redirect("CustomerDefault.aspx");

        }

        else
        {
            //error
            lblError.Text = "Something went wrong with the data entered" + Error;
        }
    }

}