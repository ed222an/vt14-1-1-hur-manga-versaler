using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hur_många_versaler.Model;

namespace Hur_många_versaler
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MyButton_Click(object sender, EventArgs e)
        {
            // Variabler
            string textToCheck = MyTextBox.Text;
            int count = TextAnalyzer.GetNumberOfCapitals(textToCheck);

            // Byter text på knappen, stänger av textfältet & skriver ut antalet versaler.
            MyButton.Visible = false;
            ResetButton.Visible = true;
            MyTextBox.Enabled = false;
            Counter.Text = "Texten innehåller " + count + " versaler.";
        }
    }
}