<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="JobApplication.aspx.cs" Inherits="WebApp.SamplePages.JobApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Job Application</h1>
    <div class="row col-sm-12">
        <div class="alert alert-info">
            <blockquote style="font-style:italic">
                This illustrates some simple controls to fill out an online
                job application. This form will use CSS-Grid formatting. This
                page will demonstrate handling of a CheckBoxList. This page will
                demonstrate grid within grid css formatting.
            </blockquote>
            <p>
                Please fill out the following form and click Submit to apply
                for the list of job(s).
            </p>

        </div>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldFullName" runat="server" ErrorMessage="Name is required" ControlToValidate="FullName"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
     <asp:RequiredFieldValidator ID="RequiredFieldEmailAddress" runat="server" ErrorMessage="Email address is required" ControlToValidate="EmailAddress"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldPhoneNumber" runat="server" ErrorMessage="Phone number is required" ControlToValidate="PhoneNumber"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
      <asp:RequiredFieldValidator ID="RequiredFieldPosition" runat="server" ErrorMessage="Select Full or Part time" ControlToValidate="FullOrPartTime"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <div class="row">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" CssClass="alert alert-danger" HeaderText="Correct the following concerns and resubmit."/>
    </div>
     <div class="row">
        <div class="grid-form">
             <h3>Job Application Form</h3> 
             <asp:Label ID="Label1" runat="server" Text="Name"
                     AssociatedControlID="FullName"></asp:Label>
                <asp:TextBox ID="FullName" runat="server"></asp:TextBox>

                <asp:Label ID="Label2" runat="server" Text="Email"
                     AssociatedControlID="EmailAddress"></asp:Label>
                <asp:TextBox ID="EmailAddress" runat="server"></asp:TextBox>

                <asp:Label ID="Label3" runat="server" Text="Phone"
                     AssociatedControlID="PhoneNumber"></asp:Label>
                <asp:TextBox ID="PhoneNumber" runat="server"></asp:TextBox>

                <asp:Label ID="Label4" runat="server" Text="Time"
                     AssociatedControlID="FullOrPartTime"></asp:Label>
                <asp:RadioButtonList ID="FullOrPartTime" runat="server"
                     RepeatDirection="Horizontal" RepeatLayout="Flow">
                    <asp:ListItem>&nbsp;Full Time&nbsp;&nbsp;</asp:ListItem>
                    <asp:ListItem>&nbsp;Part Time&nbsp;&nbsp;</asp:ListItem>
                </asp:RadioButtonList>
        
                <asp:Label ID="Label5" runat="server" Text="Jobs"
                     AssociatedControlID="Jobs"></asp:Label>
                <asp:CheckBoxList ID="Jobs" runat="server"
                     RepeatLayout="Flow"  >
                    <asp:ListItem>Sales</asp:ListItem>
                    <asp:ListItem>Manufacturing</asp:ListItem>
                    <asp:ListItem>Accounting</asp:ListItem>
                    <asp:ListItem>Shipping/Receiving</asp:ListItem>
                </asp:CheckBoxList>
                <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />&nbsp;&nbsp;
                <asp:Button ID="clear" runat="server" Text="Clear" OnClick="clear_Click" />
                <asp:Label ID="Message" runat="server" ></asp:Label>
        </div>
    </div>
</asp:Content>
