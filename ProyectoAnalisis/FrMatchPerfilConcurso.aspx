<%@ Page Title="" Language="C#" MasterPageFile="~/IndexAdmin.Master" AutoEventWireup="true" CodeBehind="FrMatchPerfilConcurso.aspx.cs" Inherits="ProyectoAnalisis.FrMatchPerfilConcurso" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/estilo.css" rel="stylesheet" />
</asp:Content>



<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

     <form runat="server" id="Formulario1" class="form-group" cols="20">
        <asp:ScriptManager ID="ScriptManager1" runat="server" LoadScriptsBeforeUI="true"
            EnablePartialRendering="true" />
        <h2>Match Concursos con Perfiles</h2>
         <br />
        <h5 class="text-info">Aqui podra escoger un concurso y ver los perfiles que aplicaron al mismo y su porcentaje de similitud</h5>
        <hr />

        

        <%--Para evitar recargar todo la pagina al seleccionar un requisito se usa update panel--%>


        <asp:UpdatePanel ID="UpdatePanel2" runat="server">

            <ContentTemplate>

                <fieldset id="data1" runat="server">
                  
                    <div style="overflow: scroll" id="datos1" runat="server">
                    <asp:GridView ID="dgvrequisitos" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgvIdiomas_SelectedIndexChanged" AllowPaging="True" OnPageIndexChanging="dgvrequisitos_PageIndexChanging" PageSize="5">
                        <Columns>
                            <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                        </Columns>
                    </asp:GridView>
                        </div>

                    <!-- Form Name -->
                    <legend>Concurso</legend>

                    <!-- Text input-->
                    <br />
            <div class="form-group">
                <label class="col-md-4 control-label" for="txtReq">ID del concurso a buscar</label>
                <div class="col-md-4">
                    <input id="txtReq" runat="server" name="txtReq" type="text" readonly="true" required="required" class="form-control input-md">
                    <asp:RequiredFieldValidator ID="rfvReq" runat="server" ControlToValidate="txtReq" ErrorMessage="*Id requerido" ForeColor="Red" ValidationGroup="frCon"></asp:RequiredFieldValidator>

                </div>
            </div>


            <!-- Button -->
            <div class="form-group">
                <label class="col-md-4 control-label" for="singlebutton"></label>
                <div class="col-md-4">
                    <asp:Button ID="addRequi" runat="server" Text="Mostrar Concursantes que aplicaron" CommandName="bind" CssClass="btn btn-primary" OnClick="addRequi_Click" ValidationGroup="frCon"/>
                </div>
            </div>

        </fieldset>
                <hr id="hhhhr" runat="server"/>
           
                
                  <h2 runat="server" visible="false" id="hh">Perfiles Aplicantes</h2>
        <asp:GridView ID="dgv2" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True" OnSelectedIndexChanged="dgv2_SelectedIndexChanged"  >
          <Columns>
                            <asp:ButtonField CommandName="Select" runat="Server" Text="Ver Informacion del aplicante" />
                        </Columns>
            </asp:GridView>
             

               
                    <div class="col-md-4" runat="server" visible="false" id="btndi">
                        <br>
                        <br>

                        <br>
                    <asp:Button ID="BtnNewBusqueda" runat="server" Text="Nueva Busqueda" CssClass="btn btn-primary" OnClick="addRequi2_Click"/>
             
                    
                <br />


                <br />    
                    </div>
             

               
                       <div style="overflow: scroll" id="Div1" runat="server" visible="false">
                           <h3>Informacion del candidato</h3>
                    <asp:GridView ID="dgv3" runat="server" CssClass="table table-striped table-bordered" EnableTheming="True"  AllowPaging="True"  PageSize="5">
                    
                    </asp:GridView>
                           <br />
                             <br />
                             <br />
                        <div class="col-md-4" runat="server" id="Div2">
                    <asp:Button ID="Button1" runat="server" Text="Ver otro Perfil" CssClass="btn btn-primary" OnClick="Button1_Click" />
                </div>
                           <br />
                           <br />
                           <br />
                           <br />
                           <br />
                       </div>

            </ContentTemplate>   
        </asp:UpdatePanel>


                      
        
         
             
     

        
</form>
</asp:Content>
