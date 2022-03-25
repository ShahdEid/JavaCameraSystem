using CameraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JavaStaffView : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        /*//create an instance of the clsStock
        clsStaff MyStock = new clsStock();
        //get the data from the session object
        MyStock = (clsStock)Session["MyStock"];
        //display the stock name for this entry
        Response.Write(MyStock.StockName);*/
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaffs();
        }
    }
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

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("JavaStaff.aspx");
    }

    protected void btnStaffEdit_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the edit page
            Response.Redirect("JavaStaff.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to edit from the list";
        }
    }

    protected void btnStaffDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaff.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StaffID= Convert.ToInt32(lstStaff.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("JavaStaffDelete.aspx");
        }
        else //if no record has been selected
        {
            //display an error
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    Int32 DisplayStaffs(string customerFName)
    {
        //variables
        Int32 StaffID;
        string StaffName;
        string StaffStreet;
        DateTime StaffDOB;
        string StaffPhoneNo;
        string StaffPostCode;
        string StaffHouseNo;
        DateTime DateAdded;

        

        //create an instance 
        clsStaffCollection Staffs = new clsStaffCollection();
        Staffs.ReportByStaffName("StaffName");
        //var to store record count
        Int32 RecordCount;
        Int32 Index = 0;
        RecordCount = Staffs.Count; //records from tblCustomers
        lstStaff.Items.Clear();
        while (Index < RecordCount) //while there are records to process
        {
            //get these attributes
            StaffID = Staffs.StaffList[Index].StaffID;
            StaffName = Staffs.StaffList[Index].StaffName;
            StaffStreet  = Staffs.StaffList[Index].StaffStreet;
            StaffDOB = Convert.ToDateTime(Staffs.StaffList[Index].StaffDOB);
            StaffPhoneNo = Staffs.StaffList[Index].StaffPhoneNo;
            StaffPostCode = Staffs.StaffList[Index].StaffPostCode;
            StaffHouseNo = Staffs.StaffList[Index].StaffHouseNo;
            DateAdded = Convert.ToDateTime(Staffs.StaffList[Index].DateAdded);
            //create the new entry for the list box
            ListItem NewEntry = new ListItem(StaffName + " " + StaffStreet + " " + StaffDOB + " " + StaffPhoneNo + " " + StaffPostCode + "" + StaffHouseNo, StaffID.ToString());
            lstStaff.Items.Add(NewEntry); //add new customer to the list
            Index++; // index to the next record
        }
        return RecordCount;
    }
    protected void btnStaffApply_Click(object sender, EventArgs e)
    {

        Int32 RecordCount;
        RecordCount = DisplayStaffs(txtStaffName.Text);
        lblError.Text = RecordCount + " Staff is shown";
    }

    protected void btnStaffDisplayAll_Click(object sender, EventArgs e)
    {
        Int32 RecordCount;
        RecordCount = DisplayStaffs("");
        lblError.Text = RecordCount + "records in Java Cameras database";
        txtStaffName.Text = "";
    }
}