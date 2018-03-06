using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Challenge1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Click_Click(object sender, EventArgs e)
        {
            string place1 = place1TextBox.Text;
            string place2 = place2TextBox.Text;

            string result = "You live in " + place1 + " now.  You will go to " + place2 + ", someday.  I wish you good luck.";

            resultLabel .Text= result;
        }
    }
}