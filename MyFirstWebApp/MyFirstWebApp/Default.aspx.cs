using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //string firstName = firstNameTextBox.Text;
            //string firstName;
            //firstName = "Bob";
            //resultLabel.Text = firstName;

            //string firstName = firstNameTextBox.Text;

            /*
            double k = 2.5;
            int j = (int)k;

            //resultLabel.Text = j;
            //resultLabel.Text = (string)j; // can not useful
            resultLabel.Text = j.ToString();
            */

            /*
            string lastName = lastNameTextBox.Text;
            
            string result = $"Hello {firstName} {lastName}";

            resultLabel.Text = result;
            */
            
            string i = inputTextBox.Text;
            int j = int.Parse(i);
            int k = j + 1;
            resultLabel.Text = k.ToString();
            

        }
    }
}