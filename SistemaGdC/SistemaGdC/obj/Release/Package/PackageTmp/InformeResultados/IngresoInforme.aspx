<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IngresoInforme.aspx.cs" Inherits="SistemaGdC.Informe.IngresoInforme" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <link href="~/Content/bootstrap.css" rel="stylesheet" media="screen" />
    <h2>&nbsp;</h2>
    <h2>Ingreso de Informe De Resultados</h2>
    <div class="jumbotron">
        <div class="form-horizontal">
            <div class="form-group">

                <label class="col-sm-1"><span style="font-size: medium">No.</span>: </label>
                <div class="col-sm-1">
                    <asp:Label ID="txtTelefono" CssClass="label" Text="xxx" runat="server"></asp:Label>
                </div>
                <label class="col-sm-1">
                    <span style="font-size: medium">año</span>: 
                </label>
                <div class="col-sm-2">
                    <asp:TextBox ID="txtanio" CssClass="form-control input" TextMode="Number" runat="server"></asp:TextBox>
                    
                </div>
                <div class="col-sm-10"></div>

            </div>
            <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">No.Evaluacion</span>: </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtInforme" CssClass="form-control input " runat="server"></asp:TextBox>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">Fecha Informe</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtFechaInforme" CssClass="form-control input" TextMode="Date" runat="server"></asp:TextBox>
                </div>

            </div>
             <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">Accion Generada</span>: </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlAccionGenerada" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">No.Hallazgo</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtHallazgo" CssClass="form-control input"  runat="server"></asp:TextBox>
                </div>

            </div>
             <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">Punto de Norma</span>: </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtPuntoNorma" CssClass="form-control input" runat="server"></asp:TextBox>
                    
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">Proceso Relacionado</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlProceso" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>

            </div>
            
             <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">Unidad</span>: </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlUnidad" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">Dependencia</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlDependencia" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>

            </div>
            <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">Descripcion</span>: </label>
                <div class="col-sm-8">
                    <asp:TextBox ID="txtDescripcion" Width="100%"  CssClass="form-control col-lg-8" TextMode="MultiLine" runat="server"></asp:TextBox>
                </div>
               
            </div>
            <div class="form-group">

                <label class="col-sm-2"><span style="font-size: small">Responsable</span>: </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlResponsable" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">Analista</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="ddlAnalista" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>

            </div>
            <div class="form-group">

               <label class="col-sm-2">
                    <span style="font-size: small">Fecha Informe</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtFechaSolicitud" CssClass="form-control input" TextMode="Date" runat="server"></asp:TextBox>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">Tipo Accion/Informe</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:DropDownList ID="dllTipoAccion" CssClass="dropdown input-sm" Width="100%" runat="server" Enabled="true"></asp:DropDownList>
                </div>

            </div>
            <div class="form-group">

               <label class="col-sm-2">
                    <span style="font-size: small">Fecha Recepcion</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtFechaRecepcion" CssClass="form-control input" TextMode="Date" runat="server"></asp:TextBox>
                </div>
                <label class="col-sm-2">
                    <span style="font-size: small">No.Plan Accion</span>: 
                </label>
                <div class="col-sm-3">
                    <asp:TextBox ID="txtNoPlanAccion" CssClass="form-control input"  runat="server"></asp:TextBox>
                </div>

            </div>
            <div class="form-group">

               <div class="col-sm-3">
                    <asp:Button ID="btnGuardar" Text="Guardar" CssClass="btn btn-success"  runat="server" Width="100%" OnClick="btnGuardar_Click" />
                </div>
                <div class="col-sm-3">
                    <asp:Button ID="btNuevo" Text="Nuevo" CssClass="btn btn-warning"  runat="server" Width="100%" />
                </div>
                <div class="col-sm-3">
                    <asp:Button ID="btnListado" Text="Listado" CssClass="btn btn-info"  runat="server" Width="100%" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
