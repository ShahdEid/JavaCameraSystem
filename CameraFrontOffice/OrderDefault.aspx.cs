using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class OrderDefault : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }



    void DisplayOrders()

    {
        CameraClasses.clsOrderCollection Orders = new CameraClasses.clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderID";
        lstOrders.DataTextField = "Quantity";
        lstOrders.DataBind();
    }





    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("AnOrdr.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if(lstOrders.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrders.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("Delete.aspx");

        }
        else
        {
            lblError.Text = "please select a record to delete from the list";
        }
    }
}

