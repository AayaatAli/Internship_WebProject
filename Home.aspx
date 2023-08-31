<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Second.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/cssHome.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <script>

</script>

    <div class="text-center container">

        <header class="masthead bg-primary text-white text-center">
            <div class="container d-flex align-items-center flex-column">
                <!-- Masthead Avatar Image-->
                <img class="masthead-avatar mb-5" src="assets/img/avataaars.svg" alt="..." />
                <!-- Masthead Heading-->
                <h1 class="masthead-heading text-uppercase mb-0">Home</h1>

            </div>
        </header>

        <h2>
            <asp:Label ID="sessionlbl" runat="server"></asp:Label>
        </h2>


        <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/material-design-iconic-font/2.2.0/css/material-design-iconic-font.min.css">
        <div class="container">
            <div class="row clearfix">








                <asp:Repeater ID="rptrProducts" runat="server">
                    <ItemTemplate>
                        <div class="col-lg-3 col-md-4 col-sm-12">
                            <div class="card product_item">


                                <a style="text-decoration:none" href="ProductView.aspx?Product_ID=<%# Eval("Product_ID") %>">

                                    <div class="body">
                                        <div class="cp_img">


                                            <%-- image tag--%>

                                            <img src='<%#Eval("P_img") %>' alt="Product" class="img-fluid">


                                            <div class="hover">
                                                <%--<a href="javascript:void(0);" class="btn btn-primary btn-sm waves-effect"><i class="zmdi zmdi-plus"></i></a>--%>
                                                <%--<a href="javascript:void(0);" class="btn btn-primary btn-sm waves-effect"><i class="zmdi zmdi-plus"></i></a>--%>


                                                <%--   <a href="javascript:void(0);" class="btn btn-primary btn-sm waves-effect">
                                                <asp:Button ID="addCart" runat="server" /><i class="zmdi zmdi-plus"></i></a>--%>

                                                <%--<a href="Home.aspx?Product_ID=<%# Eval("Product_ID") %>" id="btnAddToCart" onserverclick="btnAddToCart_Click" class="btn btn-primary btn-sm waves-effect"><i class="zmdi zmdi-shopping-cart"></i></a>--%>

                                                <%--<a href='ShoppingCart.aspx?Product_ID=<%# Eval("Product_ID") %>'class="btn btn-primary btn-sm waves-effect"><i class="zmdi zmdi-plus"></i></a>--%>

                                                <%--  Button with Onclick(Main Button)--%>
                                                <%--<asp:LinkButton   ID="btnAddToCart" runat="server" CssClass="btn btn-primary form-control" OnClick="btnAddToCart_Click">
<i class="glyphicon glyphicon-search"></i>Add To Cart</asp:LinkButton>--%>


                                                <%--                                            <i class="zmdi zmdi-plus">
                                                <asp:Button ID="btnLogOut" class="btn btn-link btn btn-primary btn-sm waves-effect" runat="server" />
                                            </i>--%>
                                            </div>
                                        </div>
                                        <div class="product_details">

                                            <%--<h5><a href="ec-product-detail.html"><%#Eval("P_Name") %></a></h5>--%>
                                            <h6><%#Eval("P_Name") %> </h6>

                                            <%--  <h6>
                                            <asp:Label ID="P1" runat="server" Text="Simple Black Clock"></asp:Label>
                                        </h6>--%>



                                            <ul class="product_price list-unstyled">
                                                <li class="old_price">$<%#Eval("P_Price") %></li>
                                                <%--<li >$</li>--%>
                                            </ul>
                                        </div>
                                    </div>

                                </a>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>











            </div>
        </div>




    </div>




</asp:Content>
