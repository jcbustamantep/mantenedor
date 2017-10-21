<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.App_Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Mantenedor Paises</title>
    <link href="../vendors/jquery-confirm/dist/jquery-confirm.min.css" rel="stylesheet"/>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<asp:TextBox ID="Textinsert" runat="server" pattern="[A-Za-z]"></asp:TextBox>
         <button type="button" class="btn btn-app pull-right" id="btnNuevoPais"  onshow ="../pages/agregar.html"><i class="fa fa-big fa-plus "></i>Agregar</button>
        <table class="table table-hover table-bordered" id="tbPais">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>Nombre</th>
                            </tr>
                    </thead>
                    <tbody>
                        
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                    </tbody>--%>
                <%--</table>--%>
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        
        
    </div>
    </form>
</body>
</html>



