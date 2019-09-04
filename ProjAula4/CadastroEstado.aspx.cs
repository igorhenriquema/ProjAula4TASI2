using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula4
{
    public partial class CadastroEstado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado()
            {
                descricao = TxtDescricao.Text
            };

            dbAula4Entities context = new dbAula4Entities();

            context.Estado.Add(estado);
            context.SaveChanges();
            LoadGrid();
            SendMessage("Registro Inserido!");
        }

        private void LoadGrid() 
            {
                GVEstado.DataSource = new dbAula4Entities().Estado.ToList<Estado>();
                GVEstado.DataBind();
            }
        private void SendMessage(string txt)
        {
            LblMsg.Text = txt;
        }
    }
}