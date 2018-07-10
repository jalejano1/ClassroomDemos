using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class JobApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            FullName.Text = "";
            EmailAddress.Text = "";
            PhoneNumber.Text = "";
            FullOrPartTime.ClearSelection();
            Jobs.ClearSelection();
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string position = FullOrPartTime.SelectedValue == "1" ? "Full" : "Part";
                string msg = "Name: " + FullName.Text + " Email: " + EmailAddress.Text
                            + " Phone: " + PhoneNumber.Text + " Position: "
                            + position;

                //traverse the checkboxlist, review one item
                //    at a time and add those items to the message
                //IF no items were choosen then add a message stating
                //    that no items were choosen to the message
                //unlike processing a checkbox group used during Razor
                //    there is no need to declare a delimiter. The 
                //    CheckBoxList object divides the checkbox choices
                //    into a collection referred to by the .Items property.
                //    This collection is an ideal candidate for using
                //    the foreach loop structure.

                msg += " Jobs: ";

                bool found = false;

                foreach (ListItem jobrow in Jobs.Items)
                {
                    if (jobrow.Selected)
                    {
                        msg += jobrow.Text + " ";
                        found = true;
                    }
                }

                if (!found)
                {
                    msg += " you did not select a job. Application rejected.";
                }

                Message.Text = msg;
            }
        }
    }
}