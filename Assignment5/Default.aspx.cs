﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        VenueRegistrationService.VenueRegistrationServiceClient vr = new VenueRegistrationService.VenueRegistrationServiceClient();

        int key = vr.VenueLogin(txtUserName.Text, txtPassword.Text);

        if (key > 0)
        {
            Session["key"] = key;
            Response.Redirect("Show.aspx");
        }
        else
        {
            lblMessage.Text = "login failed";
        }
    }
}
