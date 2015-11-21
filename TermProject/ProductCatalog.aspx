<%@ Page Title="" Language="C#" MasterPageFile="~/TP_AmazonMasterPage.Master" AutoEventWireup="true" CodeBehind="ProductCatalog.aspx.cs" Inherits="TermProject.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div style="width: 1017px; margin-right: 0px;">
    <asp:Label ID="lblselectDep" runat="server" Text="Select a Department"></asp:Label>
    &nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="ddlDepartments" runat="server" Height="24px" Width="420px" AutoPostBack="True" OnSelectedIndexChanged="ddlDepartments_SelectedIndexChanged">
    </asp:DropDownList>
    </div>

    <br />

    

     <asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="False" Height="247px" style="margin-right: 21px; margin-top: 6px; margin-left: 29px;" Width="856px" OnSelectedIndexChanged="gvProducts_SelectedIndexChanged">
        <Columns>
            
            <asp:TemplateField>

                <ItemTemplate>
                    <div style= margin-left: 5px; margin-right: 2px">
                            <asp:Label ID="lblProductName" runat="server" Text="Label" width="100%"></asp:Label>
                     </div> 

                     <div style="height: 225px; width: 307px">      
                            <asp:Image ID="imgProduct" runat="server" width="105%"
                            ImageUrl='<%# Bind("ImageFile", "Images/Products/{0}") %>' Height="230px" />
                     </div>
                       
                     <div>
                             <asp:Button ID="btnView" runat="server" Text="View" style="margin-bottom: 5px" Width="208px"  />
                        </div>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField>
                
                <ItemTemplate>
                     <div style= margin-left: 5px; margin-right: 2px">
                            <asp:Label ID="lblProductName" runat="server" Text="Label" width="100%"></asp:Label>
                     </div> 

                     <div>      
                            <asp:Image ID="imgProduct" runat="server" width="100%"
                            ImageUrl='<%# Bind("ImageFile", "Images/Products/{0}") %>' />
                     </div>
                       
                     <div>
                             <asp:Button ID="btnView" runat="server" Text="View" style="margin-bottom: 5px" Width="208px"  />
                        </div>
                </ItemTemplate>

            </asp:TemplateField>




            <asp:TemplateField>
               <ItemTemplate>
<div style= margin-left: 5px; margin-right: 2px">
                    <asp:Label ID="lblProductName" runat="server" Text="Label" width="100%"></asp:Label>
                     </div> 

                     <div>      
                            <asp:Image ID="imgProduct" runat="server" width="100%"
                            ImageUrl='<%# Bind("ImageFile", "Images/Products/{0}") %>' />
                     </div>
                       
                     <div>
                             <asp:Button ID="btnView" runat="server" Text="View" style="margin-bottom: 5px" Width="208px"  />
                        </div>
                </ItemTemplate>
            </asp:TemplateField>
            


        </Columns>
    </asp:GridView>
    <br />
   <br />

    

     </asp:Content>
