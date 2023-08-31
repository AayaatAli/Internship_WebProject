<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Second.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
  


    <%--<form>--%>
    <!-- Email input -->
    <div class="text-center container">

        <header class="masthead bg-primary text-white text-center">
            <div class="container d-flex align-items-center flex-column">
                <!-- Masthead Avatar Image-->
                <img class="masthead-avatar mb-5" src="assets/img/avataaars.svg" alt="..." />
                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0">Registration</h1>
             
            </div>
        </header>
        <br />

        <!--User name-->

        <div class=" form-outline mb-4">
            <label class="form-label" for="form2Example2">User Name</label>
            <%--<button type="button" class="btn btn-primary btn-block mb-4">Sign in</button>--%>
            <div class="container d-flex align-items-center flex-column">
                <asp:TextBox ID="TextBox3" CssClass="form-control" runat="server" Style="width: 250px" placeholder="Enter User Name"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="User Name cannot be blank" ControlToValidate="TextBox3" ForeColor="Red" CssClass="text-danger"></asp:RequiredFieldValidator>--%>
            </div>
        </div>



        <div class=" form-outline mb-4">
            <label class="form-label" for="form2Example1">Email address&nbsp; </label>
            &nbsp;<%-- <input type="password" id="form2Example2" class="form-control" />--%>
            <div class="container d-flex align-items-center flex-column">
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Style="width: 250px" placeholder="Enter Email" TextMode="Email"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Email cannot be blank" ControlToValidate="TextBox1" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </div>
        </div>

        <!-- Password input -->
        <div class=" form-outline mb-4">
            <label class="form-label" for="form2Example2">Password</label>
            <%--<button type="button" class="btn btn-primary btn-block mb-4">Sign in</button>--%>
            <div class="container d-flex align-items-center flex-column">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Style="width: 250px" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password cannot be blank" ControlToValidate="TextBox2" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </div>
        </div>

        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />

        <asp:Button ID="Button2" class="btn btn-primary" runat="server" Text="Register" OnClick="Button2_Click" />
        <br />
        <br />




        
    </div>


</asp:Content>
