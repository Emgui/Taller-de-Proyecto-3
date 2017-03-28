<%@ Page Title="" Language="C#" MasterPageFile="~/Template/Main.Master" AutoEventWireup="true" CodeBehind="GestionPedigri.aspx.cs" Inherits="webAppPetCenter.GestionPedigri" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <div class="panel-default">
  <h4>Registro de Solicitud de Pedigri</h4>
    </div>
    <div class="form-group">
    <label for="inputEmail3" class="col-sm-2 control-label">Datos de Cliente</label>
    <div class="col-sm-10">
          
        <button type="button" class="btn btn-info btn-sm">
            <span class="glyphicon glyphicon-star" aria-hidden="true"></span> 
  <span class="glyphicon glyphicon-search" aria-hidden="true"></span> Buscar Cliente
</button>     
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentScriptHolder" runat="server">
</asp:Content>
