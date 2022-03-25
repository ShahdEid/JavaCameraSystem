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
        Add();
        Response.Redirect("OrderDefault.aspx");


    }


    void Add()
    {
        CameraClasses.clsOrderCollection OrderBook = new CameraClasses.clsOrderCollection();
        string Error = OrderBook.ThisOrder.Valid(txtDateOfOrder.Text, txtCustomerID.Text, txtProductID.Text, txtQuantity.Text);
        if (Error =="")
        {
            OrderBook.ThisOrder.DateOfOrder = Convert.ToDateTime(txtDateOfOrder.Text);
            OrderBook.ThisOrder.Quantity = txtQuantity.Text;
            OrderBook.ThisOrder.PaymentStatus = chkPaymentStatus.Checked;
            OrderBook.ThisOrder.ProductID = Convert.ToInt32(ddlProductID.SelectValue);
            OrderBook.ThisOrder.CustomerID = Convert.ToInt32(ddlCustomerID.SelectValue);
            OrderBook.Add();


        }
        else
        {
            lblError.Text = "there were problems with the data enterd" + Error;

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
