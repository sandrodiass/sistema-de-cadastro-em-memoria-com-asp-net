using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace asp_net
{
    public partial class Cadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostarlista();
        }
        public void mostarlista()
        {
            
            PnlResultado.Visible = true;
            GridResultado.DataSource = Usuario.Lista;
            GridResultado.DataBind();


        }
        public void mostarcadastro() 
        {
          
            pnlCampoCadastro.Visible = true;
            
           
        }


        protected void btnsalvar_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario();
            usuario.Nome = txtnome.Text;
            usuario.Telefone = txttelefone.Text;
            usuario.gmail = Txtgamil.Text;
            usuario.Salvar();
            Txtgamil.Text = "";
            txttelefone.Text = "";
            txtnome.Text = "";
            mostarlista();
        }

        protected void BtnCadastro_Click(object sender, EventArgs e)
        {
          
           
            mostarcadastro();
        }
    }
}
