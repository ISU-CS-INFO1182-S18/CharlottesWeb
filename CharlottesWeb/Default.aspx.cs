using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharlottesWeb {
    public partial class Default : System.Web.UI.Page {
        //int _CountOfClicks = 0;
        protected void Page_Load(object sender, EventArgs e) {
            if (Session["Count"] == null) {
                Session.Add("Count", 0);
            }
        }

        protected void btnDoSomething_Click(object sender, EventArgs e) {
            //_CountOfClicks++;
            //lblOutput.Text = "I was clicked "+ _CountOfClicks+ " times.";
            //State.Counts++;
            //lblOutput.Text = "I was clicked " + State.Counts + " times.";
            int count = (int)Session["Count"];
            count++;
            lblOutput.Text = "I was clicked " + count + " times.";
            Session["Count"] = count;
            SuperHero sup = new SuperHero("Stuper","Mann");
            lblOutput.Text += sup.FullName;
            Session.Add("Super", sup);

        }
    }
}