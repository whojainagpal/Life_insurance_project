﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication13
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Initial catalog=Life_Insurace_System; integrated security=true;server=VDILEWVPNTH508");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tblSuperAdmin SET Password='" + TextBox2.Text + "' where UserID ='" + TextBox1.Text + "';", con);
            cmd.ExecuteReader();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin.aspx");
        }
    }
}