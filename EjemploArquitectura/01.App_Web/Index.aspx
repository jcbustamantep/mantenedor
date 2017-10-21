<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="_01.App_Web.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" lang="es">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TInsert" runat="server" pattern="[A-Za-z]"></asp:TextBox>
         <button type="button" class="btn btn-app pull-right" id="btnNuevoPais"><i class="fa fa-big fa-plus "></i>Agregar</button>
        <table class="table table-hover table-bordered" id="tbPais">
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>Nombre</th>
                            </tr>
                    </thead>
                    <tbody>
                        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                        <tr>
                        </tr>
                        <tr>
                        </tr>
                    </tbody>
                </table>
        <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
        
        
    </div>
    </form>
</body>
</html>



<!-- Modal Nuevo-->
<div class="modal fade" id="modalNewpais">
        <div class="modal-dialog" role="document">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                        <span aria-hidden="true">&times;</span>
                    </button>
                    <h5 class="modal-title">Nuevo Pais</h5>
                </div>
                <form id="frmnpais" class="form-horizontal form-label-left">
                    <div class="modal-body">                    
                           <div class="form-group">
                                <label class="control-label col-md-3 col-sm-3 col-xs-12" for="nombrePais">
                                    Nombre Pais<span class="required">*</span>
                                </label>
                                <div class="col-md-9 col-sm-9 col-xs-12">
                                    <input type="text" id="nombrePais" required="required" class="form-control col-md-7 col-xs-12"/>
                                </div>
                            </div>
                        </div>
                <div class="modal-footer">
                    <button type="submit" class="btn btn-dark">Crear</button>
                    <button type="button" class="btn pull-left" data-dismiss="modal" aria-label="Close">Cancelar</button>
                </div>
                </form>
            </div>
        </div>
    </div>




<!-- /Modal nuevo -->