using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class JavaStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {/*
        //cretae an instance of clsStaff
        clsStaff JavaStaff = new clsStaff();
        //get the data from the session objec
        JavaStaff = (clsStaff)Session["JavaStaff"];
        //display the house number for this entry
        Response.Write(JavaStaff.HouseNo);
        */
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {/*
        //An instamce og clsStaff
        clsStaff JavaStaff = new clsStaff();
        //capture the houuse No
        JavaStaff.HouseNo = txtHouseNo.Text;
            //store the houseNo in the session object
            Session["JavaStaff"] = JavaStaff;
        //redirect to the viewer page
        Response.Redirect("JavaStaff.aspx");
        */
    }
}