using CameraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AnOrder : System.Web.UI.Page
{



    protected void btnSave_Click(object sender, EventArgs e)
    {
        //create a new instance of clsOrder
        clsOrder AnOrder = new clsOrder();
        //caputure Date of order
        string DateOfOrder = txtDateOfOrder.Text;
        // caputure the quantity 
        string Quantity = txtQuantity.Text;
        //caputure the product id 
        string ProductID = txtProductID.Text;
        //caputure the customer id
        string CustomerID = txtCustomerID.Text;
        // variable error
        string Error = "";
        // validate 
        Error = AnOrder.Valid(DateOfOrder, Quantity, ProductID, CustomerID);
        if (Error == "")
        {

            AnOrder.DateOfOrder = Convert.ToDateTime(DateOfOrder);
            AnOrder.Quantity = Quantity;
            AnOrder.ProductID = Convert.ToInt32(txtProductID.Text);
            AnOrder.CustomerID = Convert.ToInt32(txtCustomerID.Text);
            // store the address 
            Session["AnOrder"] = AnOrder;
            // redirect to the viewer page
            Response.Write("OrderViewer.aspx");
        }
        else
        {
            // display the message 
            lblError.Text = Error;
        }

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
