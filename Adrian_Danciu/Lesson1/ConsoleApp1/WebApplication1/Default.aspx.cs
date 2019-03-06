using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ArmyLayer;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (this.IsPostBack)
            {
                return;
            }
                        
            IArmy army  = new Army();
            var countries = army.CreateCountries();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataSource= countries;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem { Text = "Select country", Value = "0" });

            var reportArmy = army.GetFullReport();
            GridView1.DataSource = reportArmy;
            GridView1.DataBind();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "I was pressed";
            int myClicks = 0;
            if (Session["My Clicks"] != null)
            {
                myClicks = (int)Session["My Clicks"];
            }
            this.Label1.Text = (++myClicks).ToString();
            Session["My Clicks"] = myClicks;

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Button2.Text = "I was pressed";
            int myClicks = 0;
            if (ViewState["My Clicks"] != null)
            {
                myClicks = (int)ViewState["My Clicks"];
            }
            this.Label2.Text = (++myClicks).ToString();
            ViewState["My Clicks"] = myClicks;
        }

        protected void HidePanel_Click(object sender, EventArgs e)
        {
            if(Panel1.Visible == false)
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }

            else
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }

            this.ListBox1.Items.Add(new ListItem { Value = 10.ToString(), Text = 10.ToString() });
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void SearchSoldiers_Click(object sender, EventArgs e)
        {

        }
    }
}