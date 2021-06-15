using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _1_1Practice {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {
            mt_GetString();
            float fa = 3.1415926f;
            fa = (float)Math.Floor(fa * 1000) / 1000;
            Response.Write("<br />" + fa);
        }
    }
}