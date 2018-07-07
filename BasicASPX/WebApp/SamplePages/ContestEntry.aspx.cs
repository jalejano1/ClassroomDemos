using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        public static List<Entry> contestentries = new List<Entry>();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            EmailAddress.Text = "";
            PostalCode.Text = "";
            Province.SelectedIndex = 0;
            Terms.Checked = false;
            CheckAnswer.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                string Firstname = FirstName.Text;
                string Lastname = LastName.Text;
                string Streetaddress1 = StreetAddress1.Text;
                string Streetaddress2 = StreetAddress2.Text;
                string city = City.Text;
                string Emailaddress = EmailAddress.Text;
                string Postalcode = PostalCode.Text;
                string Checkanswer = CheckAnswer.Text;
                string province = Province.SelectedValue;
                bool terms = Terms.Checked;

                if(terms)
                {
                    Entry theEntry = new Entry(Firstname,
                                               Lastname,
                                               Streetaddress1,
                                               Streetaddress2,
                                               city,
                                               Emailaddress,
                                               province,
                                               Postalcode);
                    contestentries.Add(theEntry);
                    ContestEntries.DataSource = contestentries;
                    ContestEntries.DataBind();
                }
                else
                {
                    Message.Text = "You did not agree to the terms of the contest. Entry Denied";
                }
                
            }
         
           
        }
    }
}