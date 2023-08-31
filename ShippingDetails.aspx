<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShippingDetails.aspx.cs" Inherits="Second.ShippingDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/cssShippingDetails.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
    <br />
    

    <div class="container py-5">
        <div class="row d-flex justify-content-center align-items-center">
            <div class="col">
                <div class="card my-4 shadow-3">
                    <div class="row g-0">
                        <div class="col-xl-6 d-xl-block bg-image">
                            <img src="https://mdbcdn.b-cdn.net/img/Others/extended-example/delivery.webp" alt="Sample photo"
                                class="img-fluid" />
                            <div class="mask" style="background-color: rgba(0, 0, 0, 0.6)">
                                <div class=" justify-content-center align-items-center h-100">
                                    <div class=" text-center" >
                                        <i class="fas fa-truck text-white fa-3x"></i>
                                        <p class="text-white title-style">Basic Bliss delivery</p>
                                        <p class="text-white mb-0"></p>

                                        <figure class="text-center mb-0">
                                            <blockquote class="blockquote text-white">
                                                <p class="pb-3">
                                                    <i class="fas fa-quote-left fa-xs text-primary"
                                                        style="color: hsl(210, 100%, 50%);"></i>
                                                    <span class="lead font-italic">Everything at your doorstep.</span>
                                                    <i class="fas fa-quote-right fa-xs text-primary"
                                                        style="color: hsl(210, 100%, 50%);"></i>
                                                </p>
                                            </blockquote>

                                        </figure>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="col-xl-6">
                            <div class="card-body p-md-5 text-black">
                                <h3 class="mb-4 text-uppercase">Delivery Info</h3>

                                <div class="row">
                                    <div class="col-md-6 mb-4">
                                        <div class="form-outline">
                                            <input type="text" id="txtFirstName" runat="server" class="form-control" placeholder="First name" />
<%--                                            <label class="form-label" for="form3Example1m">First name</label>--%>
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-4">
                                        <div class="form-outline">
                                            <input type="text" id="txtLastName" runat="server" class="form-control " placeholder="Last name"/>
<%--                                            <label class="form-label" for="form3Example1n">Last name</label>--%>
                                        </div>
                                    </div>
                                </div>

                                <div class="form-outline mb-4">
                                    <input type="text" id="txtAddress" runat="server" class="form-control" placeholder="Address" />
<%--                                    <label class="form-label" for="form3Example8">Address</label>--%>
                                </div>








                                 <div class="row">
                                    <div class="col-md-6 mb-4">
                                        <div class="form-outline">
                                            <input type="text" id="txtState" runat="server" class="form-control " placeholder="State" />
<%--                                            <label class="form-label" for="form3Example1m">First name</label>--%>
                                        </div>
                                    </div>
                                    <div class="col-md-6 mb-4">
                                        <div class="form-outline">
                                            <input type="text" id="txtCity" runat="server" class="form-control " placeholder="City"/>
<%--                                            <label class="form-label" for="form3Example1n">Last name</label>--%>
                                        </div>
                                    </div>
                                </div>




                           <%--     <div class="row">
                                    <div class="col-md-6 mb-4">

                                        <select class="select">
                                            <option value="1">State</option>
                                            <option value="2">Option 1</option>
                                            <option value="3">Option 2</option>
                                            <option value="4">Option 3</option>
                                        </select>

                                    </div>
                                    <div class="col-md-6 mb-4">

                                        <select class="select">
                                            <option value="1">City</option>
                                            <option value="2">Option 1</option>
                                            <option value="3">Option 2</option>
                                            <option value="4">Option 3</option>
                                        </select>

                                    </div>
                                </div>--%>

                                <div class="form-outline mb-4">
                                    <input type="text" id="txtPhoneNo" runat="server" class="form-control "  placeholder="Phone Number"/>
<%--                                    <label class="form-label" for="form3Example3">Zip</label>--%>
                                </div>

                                <div class="form-outline mb-4">
                                    <input type="text" id="txtEmail" runat="server"  class="form-control" typeof="email" placeholder="Email" />
<%--                                    <label class="form-label" for="form3Example2">Email</label>--%>
                                </div>

                                <div class="d-flex justify-content-end pt-3">
                                    <%--<button type="button" class="btn btn-success btn-lg ms-2"
                                        style="background-color: hsl(210, 100%, 50%)">
                                        Place order</button>--%>

                                    <asp:Button style="color:white;background-color: hsl(0,0%,0%)" onClick="btnPlaceOrder_Click1" Class="btn" ID="btnPlaceOrder" runat="server" Text="PLACE ORDER" />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    


</asp:Content>
