<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cadastro.aspx.cs" Inherits="asp_net.Cadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
    <style>
        body {
            font-family: areal;
           
        }
   div {
         
         
	
	
	border-radius:15px;
	
    </style>
<body>
      <br/>
       <br/>
    <form id="form1" runat="server">
 <div>

        
        <asp:Panel ID="pnlCampoCadastro" runat="server">      
        <asp:Label ID="Label1" runat="server" Text="NOME"></asp:Label>
            </br>
        <asp:TextBox ID="txtnome" runat="server"></asp:TextBox>
            <br/>
        <asp:Label ID="Label2" runat="server" Text="TELEFONE"></asp:Label>
        </br>
         <asp:TextBox ID="txttelefone" runat="server"></asp:TextBox>
            <br/>
        <asp:Label ID="Label3" runat="server" Text="GMAIL"></asp:Label>
        </br>
         <asp:TextBox ID="Txtgamil" runat="server"></asp:TextBox>

     
        <br/>
        <asp:Button ID="btnsalvar" runat="server" Text="Salvar" OnClick="btnsalvar_Click" />
        </asp:Panel>
 </div>
        <br/>
        <asp:Panel ID="PnlResultado" runat="server">
            <br/>
            <asp:Button ID="BtnCadastro" runat="server" Text="CADASTROS" OnClick="BtnCadastro_Click" /> 
            <br/>
            <asp:GridView ID="GridResultado" runat="server">
                
            </asp:GridView>
        </asp:Panel>

      
    
    
   </form>

</body>
</html>
