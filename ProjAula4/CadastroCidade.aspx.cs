using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjAula4
{
    public partial class CadastroCidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDDL();
                LoadGrid();
            }
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {

            int idEstado = int.Parse(DDLEstado.SelectedValue.ToString());

            dbAula4Entities context = new dbAula4Entities();

            SendMessage("Registro Inserido!");

            Cidade2 cidade = new Cidade2()
            {
                descricao = TxtDescricao.Text,
                Estado = context.Estado.First<Estado>(Validate => Validate.id == idEstado)
            };

            context.Cidade2.Add(cidade);
            context.SaveChanges();
            LoadGrid();
        }

        private void LoadGrid()
        {
            dbAula4Entities context = new dbAula4Entities();

            var dados = (from c in context.Cidade2
                         from e in context.Estado.Where(x => x.id == c.idEstado)
                         select new
                         {
                             idCidade = c.id,
                             NomeCidade = c.descricao,
                             estado = e.descricao
                         }).ToList();

            GVCidade.DataSource = dados;
            GVCidade.DataBind();
        }

        private void LoadDDL()
        {
            DDLEstado.DataSource = new dbAula4Entities().Estado.ToList<Estado>();
            DDLEstado.DataTextField = "descricao";
            DDLEstado.DataValueField = "id";
            DDLEstado.DataBind();
        }

        private void SendMessage (String txt)
        {
            LblMSG.Text = txt;
        }
    }
}