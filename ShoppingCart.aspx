<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ShoppingCart.aspx.cs" Inherits="Second.ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/cssShoppingCart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <%--    <div class="text-center container">
        <header class="masthead bg-primary text-white text-center">
            <div class="container d-flex align-items-center flex-column">
                <!-- Masthead Avatar Image-->
                <img class="masthead-avatar mb-5" src="assets/img/avataaars.svg" alt="..." />
                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0">Home</h1>

            </div>
        </header>--%>


    <br />
    <br />
    <br />
    <br />
    <br />

    <div class="card">
        <div class="row">
            <div class="col-md-8 cart">
                <div class="title">
                    <div class="row">
                        <div class="col">
                            <h4 runat="server" id="emptyCart"><b>Shopping Cart</b></h4>
                        </div>
                        <div class="col align-self-center text-right text-muted" runat="server" id="cartCount"></div>
                    </div>
                </div>

                <asp:Repeater ID="rptrCart" runat="server">
                    <ItemTemplate>


                        <div class="row border-top border-bottom">
                            <div class="row main align-items-center">
                                <div class="col-2">
                                    <img class="img-fluid" src='<%#Eval("pImg") %>'>
                                </div>
                                <div class="col">
                                    <%--<div class="row text-muted">Shirt</div>--%>
                                    <div class="row"><%#Eval("pName") %></div>
                                </div>
                                <div class="col">
<%--                                    <a href="#">-</a>--%>
                                    <a href="ProductView.aspx?Product_ID=<%# Eval("pID") %>" class="border"><%#Eval("pQuantity") %></a>
<%--                                    <a href="#">+</a>--%>
                                </div>
                                <div class="col">
                                    $<%# Convert.ToInt32(Eval("pPrice") )*Convert.ToInt32(Eval("pQuantity")) %>
                                </div>
                                <%--                                    <span class="close" >&#10005;</span>--%>
                                <%--                                    <asp:LinkButton ID="btnRemove" runat="server" OnClick="btnRemove_Click" class="close" CommandArgument='<%#Eval("pID") %>'><i class="icon icon-close"></i>&#10005;</asp:LinkButton>--%>
                                <div>
                                    <asp:Button CommandArgument='<%#Eval("pID") %>' ID="btnRemove" runat="server" OnClick="btnRemove_Click" Text="Remove" class="btn"></asp:Button>
                                </div>

                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>



                <%--              <div class="row">
                        <div class="row main align-items-center">
                            <div class="col-2">
                                <img class="img-fluid" src="https://i.imgur.com/ba3tvGm.jpg">
                            </div>
                            <div class="col">
                                <div class="row text-muted">Shirt</div>
                                <div class="row">Cotton T-shirt</div>
                            </div>
                            <div class="col">
                                <a href="#">-</a><a href="#" class="border">1</a><a href="#">+</a>
                            </div>
                            <div class="col">&euro; 44.00 <span class="close">&#10005;</span></div>
                        </div>
                    </div>
                    <div class="row border-top border-bottom">
                        <div class="row main align-items-center">
                            <div class="col-2">
                                <img class="img-fluid" src="https://i.imgur.com/pHQ3xT3.jpg">
                            </div>
                            <div class="col">
                                <div class="row text-muted">Shirt</div>
                                <div class="row">Cotton T-shirt</div>
                            </div>
                            <div class="col">
                                <a href="#">-</a><a href="#" class="border">1</a><a href="#">+</a>
                            </div>
                            <div class="col">&euro; 44.00 <span class="close">&#10005;</span></div>
                        </div>
                    </div>--%>
                <div class="back-to-shop"><a href="Home.aspx">&leftarrow;</a><span class="text-muted">Back to shop</span></div>
            </div>
            <div class="col-md-4 summary" runat="server" id="PriceDetails">
                <div>
                    <h5><b>Summary</b></h5>
                </div>
                <hr>
                <div class="row">
                    <div class="col text-left" runat="server" id="cartCount_"></div>
                    <div class="col text-right" id="P_total" runat="server"></div>
                </div>
                <hr />
                <form>
                    <p>SHIPPING</p>
                    <select>
                        <option class="text-muted">Standard-Delivery- &dollar;5.00</option>
                    </select>
                   
                 <%--   <p>GIVE CODE</p>
                    <input id="code" placeholder="Enter your code">--%>
                </form>
                <hr />
                <div class="row" style="border-top: 1px solid rgba(0,0,0,.1); padding: 2vh 0;">
                    <div class="col">TOTAL PRICE</div>
                    <div class="col text-right" id="C_total" runat="server"></div>
                </div>
<%--                <button class="btn" id="btnCheckout" onClick="btnCheckout_Click" runat="server">CHECKOUT</button>--%>
                <asp:Button class="btn" ID="btnCheckout1" runat="server" onClick="btnCheckout_Click" Text="CHECKOUT" />
            </div>
        </div>

    </div>




    <br />




</asp:Content>
