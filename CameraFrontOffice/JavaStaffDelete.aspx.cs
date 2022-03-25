using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CameraClasses;


public partial class JavaStaffDelete : System.Web.UI.Page
{
    Int32 StaffID;

    protected void Page_Load(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be deleted 
        Int32 StaffID;
        //get the number of staff to be deleted from the sessio object
        StaffID = Convert.ToInt32(Session["StaffID"]);
    }
    void DeleteStaff()
    {
        //function to delete the selected record

        //create a neew instance of custimer
        clsStaffCollection Staffs = new clsStaffCollection();
        //find rge record to delete 
        Staffs.ThisStaff.Find(StaffID);
        Staffs.Delete();
    }

    protected void btnStaffYes_Click(object sender, EventArgs e)
    {
        // delete the record
        DeleteStaff();
        //redirect back to amin page
        Response.Redirect("JavaStaff.aspx");

    }
}