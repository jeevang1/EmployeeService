using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeService
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmpReference1.EmpserviceSoapClient obj = new EmpReference1.EmpserviceSoapClient();
            int empno = int.Parse(TextBox1.Text);
            string empname = TextBox2.Text;
            double bsal = double.Parse(TextBox3.Text);
            double da = (0.2 * bsal);
            double hra = (0.4 * bsal);
            double Totalsal = bsal + da + hra;
            Label1.Text = "DA is:" + da.ToString();
            Label2.Text = "HRA is:" + hra.ToString();
           Label3.Text = "Total salary is:" + Totalsal.ToString();
            
            
        }

       
    }
}