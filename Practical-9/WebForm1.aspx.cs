using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        localhost.WebService1 calc = new localhost.WebService1();


            
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            Label1.Text = calc.Add(Convert.ToInt16(TextBox1.Text), Convert.ToInt16(TextBox2.Text)).ToString();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
             
             Label1.Text = calc.Subtract(Convert.ToInt16(TextBox1.Text), Convert.ToInt16(TextBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
             

             Label1.Text = calc.Div(Convert.ToInt16(TextBox1.Text), Convert.ToInt16(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            

            Label1.Text=calc.Multiply(Convert.ToInt16(TextBox1.Text),Convert.ToInt16(TextBox2.Text)).ToString();
        }
    }
}