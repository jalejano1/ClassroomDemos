<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ContestEntry.aspx.cs" Inherits="WebApp.SamplePages.ContestEntry" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="page-header">
        <h1>Contest Entry</h1>
    </div>

    <div class="row col-md-12">
        <div class="alert alert-info">
            <blockquote style="font-style: italic">
                This illustrates some simple controls to fill out an entry form for a contest. 
                This form will use basic bootstrap formatting and illustrate Validation.
            </blockquote>
            <p>
                Please fill out the following form to enter the contest. This contest is only available to residents in Western Canada.
            </p>

        </div>
    </div>

    <asp:RequiredFieldValidator ID="RequiredFieldFirstName" runat="server" ErrorMessage="First Name is required" ControlToValidate="FirstName" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldLastName" runat="server" ErrorMessage="Last Name is required" ControlToValidate="LastName" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldStreetAddress1" runat="server" ErrorMessage="Street Address 1 is required" ControlToValidate="StreetAddress1" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldCity" runat="server" ErrorMessage="City is required" ControlToValidate="City" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldEmailAddress" runat="server" ErrorMessage="Email Address is required" ControlToValidate="EmailAddress" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionEmailAddress" runat="server" ErrorMessage="Invalid Email Address" ControlToValidate="EmailAddress"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None" ValidationExpression="\s*\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*"></asp:RegularExpressionValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldPostalCode" runat="server" ErrorMessage="Postalcode is required" ControlToValidate="PostalCode" SetFocusOnError="true" 
         ForeColor="Firebrick" Display="None"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionPostalCode" runat="server" ErrorMessage="Invalid Postal code (sample T6T6T6)" ControlToValidate="PostalCode"
         SetFocusOnError="true" ForeColor="Firebrick" Display="None" ValidationExpression="[a-zA-Z][0-9][a-zA-Z][0-9][a-zA-Z][0-9]"></asp:RegularExpressionValidator>
<%--<asp:RangeValidator ID="RangeSomefield" runat="server" ErrorMessage="Some field value is out of range (0-100)" ControlToValidate="SomeField" SetFocusOnError="true" ForeColor="Firebrick" Display="None"
         MinimumValue="0.0" MaximumValue="100.0" Type="Double"></asp:RangeValidator>--%>
    <%--<asp:CompareValidator ID="CompareVersion1" runat="server" ErrorMessage="Version 1 is wrong data type" ControlToValidate="Version1" SetFocusOnError="true" ForeColor="Firebrick"
       Display="None" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
     <asp:CompareValidator ID="CompareVersion2" runat="server" ErrorMessage="Version 2 Value is incorrect" ControlToValidate="Version2" SetFocusOnError="true" ForeColor="Firebrick"
       Display="None" type="Currency"></asp:CompareValidator>--%>
     <asp:CompareValidator ID="CompareCheckAnswer" runat="server" ErrorMessage="Skill testing answer incorrect" ControlToValidate="CheckAnswer" SetFocusOnError="true" ForeColor="Firebrick"
       Display="None" ValueToCompare="15" type="string"></asp:CompareValidator>


    <div class="row">
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" 
             HeaderText = "Correct the following concerns and resubmit."
              CssClass ="Alert alert danger"/>
    </div>
    <div class="grid-form">
        <h3>Contest Entry</h3>
        <asp:Label ID="Label1" runat="server" Text="First Name"
                AssociatedControlID="FirstName"></asp:Label>
        <asp:TextBox ID="FirstName" runat="server" 
            ToolTip="Enter your first name." MaxLength="25"></asp:TextBox> 
                  
        <asp:Label ID="Label2" runat="server" Text="Last Name"
            AssociatedControlID="LastName"></asp:Label>
        <asp:TextBox ID="LastName" runat="server" 
            ToolTip="Enter your last name." MaxLength="25"></asp:TextBox> 
                        
        <asp:Label ID="Label3" runat="server" Text="Street Address 1"
                AssociatedControlID="StreetAddress1"></asp:Label>
        <asp:TextBox ID="StreetAddress1" runat="server" 
            ToolTip="Enter your street address." MaxLength="75"></asp:TextBox> 
                  
        <asp:Label ID="Label4" runat="server" Text="Street Address 2"
            AssociatedControlID="StreetAddress2"></asp:Label>
        <asp:TextBox ID="StreetAddress2" runat="server" 
            ToolTip="Enter your additional street address." MaxLength="75"></asp:TextBox> 

        <asp:Label ID="Label5" runat="server" Text="City"
            AssociatedControlID="City"></asp:Label>
        <asp:TextBox ID="City" runat="server" 
            ToolTip="Enter your City name" MaxLength="50"></asp:TextBox> 
                  
        <asp:Label ID="Label6" runat="server" Text="Province"
            AssociatedControlID="Province"></asp:Label>
        <asp:DropDownList ID="Province" runat="server" Width="75px">
            <asp:ListItem Value="AB" Text="AB"></asp:ListItem>
            <asp:ListItem Value="BC" Text="BC"></asp:ListItem>
            <asp:ListItem Value="MN" Text="MN"></asp:ListItem>
            <asp:ListItem Value="SK" Text="SK"></asp:ListItem>
        </asp:DropDownList>
                  
        <asp:Label ID="Label7" runat="server" Text="Postal Code"
                AssociatedControlID="PostalCode"></asp:Label>
        <asp:TextBox ID="PostalCode" runat="server" 
            ToolTip="Enter your postal code"  MaxLength="6"></asp:TextBox> 
                 
        <asp:Label ID="Label8" runat="server" Text="Email"
                AssociatedControlID="EmailAddress"></asp:Label>
        <asp:TextBox ID="EmailAddress" runat="server" 
            ToolTip="Enter your email address"
                ></asp:TextBox> 

        <asp:Label ID="Label9" runat="server" Text="Agree to Terms"
            AssociatedControlID="Terms"></asp:Label>
        <asp:CheckBox ID="Terms" runat="server" Text="I agree to the terms of the contest" />
   
        <p>Note: You must agree to the contest terms in order to be entered.</p> 
    
        <p>
            Enter your answer to the following calculation instructions:<br />
            Multiply 15 times 6<br />
            Add 240<br />
            Divide by 11<br />
            Subtract 15<br />
            <asp:TextBox ID="CheckAnswer" runat="server" ></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click"  />&nbsp;&nbsp;
            <asp:Button ID="Clear" runat="server" Text="Clear" OnClick="Clear_Click" CausesValidation="False" />
        </p>
               
        <asp:Label ID="Message" runat="server" Text="bob" ></asp:Label>

        <asp:GridView ID="ContestEntries" runat="server"></asp:GridView>
      </div>
    
</asp:Content>
