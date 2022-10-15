<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarNegocios.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 280px;
        }
        .auto-style2 {
            width: 280px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 307px;
        }
        .auto-style5 {
            height: 23px;
            width: 307px;
        }
        .auto-style6 {
            width: 280px;
            height: 42px;
        }
        .auto-style7 {
            width: 307px;
            height: 42px;
        }
        .auto-style8 {
            height: 42px;
        }
        .auto-style9 {
            width: 280px;
            height: 26px;
        }
        .auto-style10 {
            width: 307px;
            height: 26px;
        }
        .auto-style11 {
            height: 26px;
        }
        .auto-style12 {
            width: 280px;
            height: 34px;
        }
        .auto-style13 {
            width: 307px;
            height: 34px;
        }
        .auto-style14 {
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style12">
                        <asp:Label ID="lblCodigoNegocio" runat="server" Text="Codigo del negocio"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:Label ID="lblGenerarCodigo" runat="server" Text="Label" Visible="False"></asp:Label>
                        <asp:Button ID="btnGenerarCodigo" runat="server" Text="Generar" OnClick="btnGenerarCodigo_Click" />
                    </td>
                    <td class="auto-style14"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombreNegocio" runat="server" Text="Nombre de la idea de negocio"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:TextBox runat="server" ID="tbNombreNegocio"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="lblImpacto" runat="server" Text="Impacto social o económico que genera"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="tbImpacto" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="lblDepartamentos" runat="server" Text="Departamentos"></asp:Label>
                    </td>
                    <td class="auto-style5">
                        <asp:CheckBoxList ID="cblDepartamentos" runat="server" RepeatColumns="4" Width="600px">
                            <asp:ListItem Value="amazonas">Amazonas</asp:ListItem>
                            <asp:ListItem Value="antioquia">Antioquia</asp:ListItem>
                            <asp:ListItem Value="arauca">Arauca</asp:ListItem>
                            <asp:ListItem Value="atlantico">Atlántico</asp:ListItem>
                            <asp:ListItem Value="bolivar">Bolívar</asp:ListItem>
                            <asp:ListItem Value="boyaca">Boyacá</asp:ListItem>
                            <asp:ListItem Value="caldas">Caldas</asp:ListItem>
                            <asp:ListItem Value="caqueta">Caquetá</asp:ListItem>
                            <asp:ListItem Value="casanare">Casanare</asp:ListItem>
                            <asp:ListItem Value="cauca">Cauca</asp:ListItem>
                            <asp:ListItem Value="cesar">Cesar</asp:ListItem>
                            <asp:ListItem Value="choco">Chocó</asp:ListItem>
                            <asp:ListItem Value="cordoba">Córdoba</asp:ListItem>
                            <asp:ListItem Value="cundinamarca">Cundinamarca</asp:ListItem>
                            <asp:ListItem Value="guainia">Guainía</asp:ListItem>
                            <asp:ListItem Value="guaviare">Guaviare</asp:ListItem>
                            <asp:ListItem Value="huila">Huila</asp:ListItem>
                            <asp:ListItem Value="guajira">La Guajira</asp:ListItem>
                            <asp:ListItem Value="magdalena">Magdalena</asp:ListItem>
                            <asp:ListItem Value="meta">Meta</asp:ListItem>
                            <asp:ListItem Value="narinno">Nariño</asp:ListItem>
                            <asp:ListItem Value="santander">Norte de Santander</asp:ListItem>
                            <asp:ListItem Value="putumayo">Putumayo</asp:ListItem>
                            <asp:ListItem Value="quindio">Quindío</asp:ListItem>
                            <asp:ListItem Value="risaralda">Risaralda</asp:ListItem>
                            <asp:ListItem Value="sanAndres">San Andrés y Providencia</asp:ListItem>
                            <asp:ListItem Value="santander">Santander</asp:ListItem>
                            <asp:ListItem Value="sucre">Sucre</asp:ListItem>
                            <asp:ListItem Value="tolima">Tolima</asp:ListItem>
                            <asp:ListItem Value="valleCauca">Valle del Cauca</asp:ListItem>
                            <asp:ListItem Value="Vaupes">Vaupés</asp:ListItem>
                            <asp:ListItem Value="vichada">Vichada</asp:ListItem>
                        </asp:CheckBoxList>
                    </td>
                </tr>
                <tr>
                                 
                    <td class="auto-style9">
                        <asp:Label ID="lblValorInversion" runat="server" Text="Valor de la inversión"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox runat="server" ID="tbValorInversion" TextMode="Number" min="1"></asp:TextBox>
                    </td>
                    <td class="auto-style11"></td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblTotalIngresos" runat="server" Text="Total de ingresos a generar en los primeros 3 años"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="tbIngresos" runat="server" TextMode="Number" min="1"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:Button runat="server" Text="Mostrar Informacion" OnClick="Unnamed1_Click1" ID="btnMostrarInfo"></asp:Button></td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblHerramientas" runat="server" Text="Herramientas 4RI"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:CheckBoxList ID="cblHerramientas" runat="server" required="required">
                            <asp:ListItem Value="cloud_computing">Cloud Computing</asp:ListItem>
                            <asp:ListItem Value="biometria">Biometria</asp:ListItem>
                            <asp:ListItem Value="inteligencia_artificial">Inteligencia artificial</asp:ListItem>
                            <asp:ListItem Value="IoT">Internet de las cosas</asp:ListItem>
                        </asp:CheckBoxList>
                        
                    </td>
                  
                    <td>
                        <asp:TextBox ID="txtResultados" runat="server" Height="200px" TextMode="MultiLine" ReadOnly="True" Width="350px"></asp:TextBox>
                    </td>
                    

                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>

                    
                    <asp:Label runat="server" Text="[ERROR]" ID="lblError" ForeColor="Red" Visible="False"></asp:Label><asp:Label runat="server" Text="Se creó el negocio satisfactoriamente" ID="lblExitoso" ForeColor="Lime" Visible="False"></asp:Label>
                    <asp:Button ID="btnCrearNegocio" runat="server" Text="Crear negocio" Width="100" OnClick="btnCrearNegocio_Click" />
                    </td>

                </tr>


                <tr>
                    
                    <td class="auto-style3">
                        <asp:Label runat="server" Text="[ERROR]" ForeColor="Red" Visible="False" ID="lblErrorInt"></asp:Label><asp:Label runat="server" Text="Se agregó el integrante satisfactoriamente" ID="lblExitoso2" Visible="False" ForeColor="Lime"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:Label runat="server" Text="Agregar Integrantes o eliminar" ID="lblAgregarIntegrante"></asp:Label></td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Label runat="server" Text="Codigo" ID="lblCodigoInt"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="tbCodigoInt"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblIdentificacion" runat="server" Text="Identificacion"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbId" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbNombreInt" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblApellidos" runat="server" Text="Apellidos"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="tbApellidosInt"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblRol" runat="server" Text="Rol"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbRolInt" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="lblEmail" runat="server" Text="Correo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="tbCorreoInt" runat="server" TextMode="SingleLine"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    
                    <td class="auto-style1">&nbsp;</td>
                     <td>
                         <asp:Button runat="server" Text="Agregar" OnClick="Unnamed1_Click" ID="btnAgregar"></asp:Button><asp:Button runat="server" Text="Eliminar" ID="btnEliminarInt" OnClick="btnEliminarInt_Click"></asp:Button>
                     </td>
                    
                </tr>
                
                <tr>
                    <td class="auto-style1">

                    </td>
                    <td class="auto-style4">
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
