using CameraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }











    protected void btnSave_Click(object sender, EventArgs e)
    {
        //create a new instance of ClsOrder
        clsOrder AnOrder = new clsOrder();
        //caputure the quantity 
        AnOrder.Quantity=txtQuantity.Text;
        //store the order id in the session object
        Session["AnOrder"] = AnOrder;
        //redirect to the viewer page
        Response.Redirect("OrderViewer.aspx");

    }





    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create  an intance of the order class 
        clsOrder AnOrder = new clsOrder();
        //variable to store the primary key
        Int32 OrderID;
        //varibale to store the result of the find operatrion 
        Boolean Found = false;
        //get the primary key entered by the user
        OrderID = Convert.ToInt32(txtOrderID.Text);
        //find record
        Found = AnOrder.Find(OrderID);
        //if found 
        if (Found == true)
        {
            // display the values

            txtDateOfOrder.Text = AnOrder.DateOfOrder.ToString();
            txtQuantity.Text = AnOrder.Quantity;
            txtProductID.Text = AnOrder.ProductID.ToString();
            txtCustomerID.Text = AnOrder.CustomerID.ToString();


        }
    }
}