using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using project.BussinessLogic.Logic.BLL;
using project.BussinessLogic.Logic.Connect;

namespace project.Page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var reFloors = BLLPort.GetBllDtbFloor().GetDtbFloors();

            GridView1.DataSource = reFloors;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sender is GridView)
            {
                var gridView = sender as GridView;

                GridViewRow gridViewSelectedRow = gridView.SelectedRow;

                if (gridViewSelectedRow != null)
                {
                    var textbox1 = gridViewSelectedRow.FindControl("TextBox1");

                    var label1 = gridViewSelectedRow.FindControl("Label1");

                    TextBox2.Text = (textbox1 as TextBox).Text;

                    Label2.Text = (label1 as Label).Text;
                }
            }
        }
    }
}