using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        public static List<DDLCLASS> DataCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            //this method will execute on EACH and EVERY post back to this page.
            //This method will execute on the first display at this page 
            //to determine if the page is new or postback use IsPostBack property

            //this method is often use as a genera; method to reset fields or controls at the start of the page processing
            //The label MessageLabel is used to display messsages to the user
            //old message should be remove from this control on each pass

            //how does one reference a control on the .aspx form
            //to reference a from control, use the control ID name.
            //EACH control is an object. THEREFORE alter a PROPERTY value.
            MessageLabel.Text = "";

            //Determine if this is the first display of the page
            // and if so, load data into the dropdownlist

            if (!Page.IsPostBack)
            {
                //create an instance of List<T> for my "fake database" data
                DataCollection = new List<DDLCLASS>();

                //add data to he collection
                DataCollection.Add(new DDLCLASS(1, "COMP1008"));
                DataCollection.Add(new DDLCLASS(2, "CPSC1517"));
                DataCollection.Add(new DDLCLASS(3, "DMIT1508"));
                DataCollection.Add(new DDLCLASS(4, "DMIT2018"));

                //usually lists are sorted
                //the List<T> has a .Sort() behaviour (method)
                //(x, y) represents any two entries in the data collection at any point in time
                //the landa symbol => basically means "do the following"
                //.CompareTo() is a method that will compare to items and return the result
                //  of comparing two items. tHe result is interpreted by he Sort() to 
                //  to determine if the order needs to be changed. 
                //x vs y is ascending
                //y vs x is descending
                DataCollection.Sort((x, y) => x.DisplayField.CompareTo(y.DisplayField));

                //place the collection into the dropdownlist
                //a) assign the collection to the control(ID=CollectionList)
                CollectionList.DataSource = DataCollection;

                //b) assign the value and display portions of the dropdownlist
                //  to specify properties of the data class
                CollectionList.DataTextField = nameof(DDLCLASS.DisplayField);
                CollectionList.DataValueField = nameof(DDLCLASS.ValueField);

                //c) Bind the data to the collection(physical attachment)
                CollectionList.DataBind();

                //d)you may wish to add a prompt line at the beginning of the
                //  list of data within the dropdownlist
                CollectionList.Items.Insert(0, "select...");
            }
        }

        protected void SubmitButtonChoice_Click(object sender, EventArgs e)
        {
            //grab the contents of various controls and manipulate the content
            //  of other controls
            //controls have certain properties that can accessed to obtaining
            //  and assigning values
            string submitchoice = TextBoxNumberChoice.Text;

            if(string.IsNullOrEmpty(submitchoice))
            {
                MessageLabel.Text = "You did not enter a number between 1 and 4";
            }
            else
            {
                //radiobuttonlist property: SelectedIndex, SelectedValue, SelectedItem
                //SelectedIndex returns the physical line index number
                //SelectedValue returns the data value associated with the physical line **
                //SelectedItem returns the data display associated with the phsical line
                RadioButtonListChoice.SelectedValue = submitchoice;

                if(submitchoice.Equals("2") || submitchoice.Equals("4"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                CollectionList.SelectedValue = submitchoice;

                DisplayDataReadOnly.Text = CollectionList.SelectedItem.Text
                    + " at index " + CollectionList.SelectedIndex.ToString()
                    + " having a value of " + CollectionList.SelectedValue;
            }
        }

        protected void LinkButtonSubmitChoice_Click(object sender, EventArgs e)
        {
            if(CollectionList.SelectedIndex == 0)
            {
                MessageLabel.Text = "Please selected a course";
            }
            else
            {
                string ddlselection = CollectionList.SelectedValue;

                TextBoxNumberChoice.Text = ddlselection;

                RadioButtonListChoice.SelectedValue = ddlselection;

                if (ddlselection.Equals("2") || ddlselection.Equals("4"))
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }
                DisplayDataReadOnly.Text = CollectionList.SelectedItem.Text
                        + " at index " + CollectionList.SelectedIndex.ToString()
                        + " having a value of " + CollectionList.SelectedValue;

            }

        }

        protected void TextBoxNumberChoice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}