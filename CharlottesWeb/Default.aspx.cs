using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CharlottesWeb {
    public partial class Default : System.Web.UI.Page {
        int _CountOfClicks = 0;
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void btnDoSomething_Click(object sender, EventArgs e) {
            _CountOfClicks++;
            lblOutput.Text = "I was clicked "+ _CountOfClicks+ " times.";
        }
    }
}