<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Second.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%-- <div class="container">--%>


    <%--<form>--%>
    <!-- Email input -->
    <div class="text-center container">

        <header class="masthead bg-primary text-white text-center">
            <div class="container d-flex align-items-center flex-column">
                <!-- Masthead Avatar Image-->
                <img class="masthead-avatar mb-5" src="assets/img/avataaars.svg" alt="..." />
                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0">Login</h1>

            </div>
        </header>
        <br />
        <div class=" form-outline mb-4">
            <label class="form-label" for="form2Example1">User Name&nbsp; </label>
            &nbsp;<%-- <input type="password" id="form2Example2" class="form-control" />--%>


            <div class="container d-flex align-items-center flex-column">
                <asp:TextBox ID="TextBox1" CssClass="form-control" runat="server" Style="width: 250px" placeholder="Enter User Name"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="User Name field is Required!" ControlToValidate="TextBox1" ForeColor="Red" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>

        <!-- Password input -->
        <div class=" form-outline mb-4">
            <label class="form-label" for="form2Example2">Password</label>
            <%--<button type="button" class="btn btn-primary btn-block mb-4">Sign in</button>--%>

            <div class="container d-flex align-items-center flex-column">
                <asp:TextBox ID="TextBox2" CssClass="form-control" runat="server" Style="width: 250px" placeholder="Enter Password" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password field is required" ControlToValidate="TextBox2" ForeColor="Red" CssClass="text-danger"></asp:RequiredFieldValidator>
            </div>
        </div>


        <!-- 2 column grid layout for inline styling -->
        <%--  <div class="row mb-4">
            <div class="col justify-content-center">--%>
        <!-- Checkbox -->
    <%--    <div class="align-content-center form-check">
           
            <asp:CheckBox ID="CheckBox1" runat="server" type="checkbox" class="form-check-input" text="Remember me"/>
       
        </div>--%>
        <br />

        <%--</div>--%>

        <%--<div class="col">--%>
        <!-- Simple link -->
        <%--       <a href="#!">Forgot password?</a>
            </div>
        </div>--%>



        <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Sign-in" OnClick="Button1_Click" />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />


        <!-- Simple link -->
        <%-- <a href="#!">Forgot password?</a>--%>

        <div class="text-center">
            <%--<p>Not a member? <a href="#Registration.aspx">Register</a></p>--%>
            <p>Not a member? <a href="Registration.aspx">Register</a></p>
        </div>
        <%--<br />--%>
    </div>



</asp:Content>
