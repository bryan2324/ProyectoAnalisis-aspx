<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrImprimirConcurso.aspx.cs" Inherits="ProyectoAnalisis.FrImprimirConcurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
        <h4>Descargar Informacion del Concurso</h4>
    <hr />
    <br />
    <div class="form-inline" style="overflow: scroll">
        <form runat="server">
            <div id="salvador" style="overflow: scroll">
            <asp:GridView ID="gvMostrarConcurso"  runat="server" CssClass="table table-striped table-bordered dt-responsive nowrap" EnableTheming="True" AllowPaging="True" PageSize="5" OnSelectedIndexChanged="gvMostrarConcurso_SelectedIndexChanged">
                <Columns>
                    <asp:ButtonField CommandName="Select" Text="Descargar " />
                </Columns>
            </asp:GridView>
                </div>

             
     
        </form>
    </div>
</asp:Content>
