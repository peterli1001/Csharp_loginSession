using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (txtUserName.Text.Trim() == "") {
            lblPrompt.Text = "Please keyin your name";
            return;
        }
        Session["userName"] = txtUserName.Text;

        if (Session["userName"] == null) {
            Response.Redirect("Default.aspx");
        }
        else {
            Response.Redirect("Secret.aspx");
        }
    }
}