﻿using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharlottesWeb {
    public partial class Other : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

            if (Session["Super"] != null) {
                SuperHero s = (SuperHero)Session["Super"];
                lblOut.Text = s.FullName;

            }


        }
    }
}