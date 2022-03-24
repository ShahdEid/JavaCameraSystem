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



    
}

