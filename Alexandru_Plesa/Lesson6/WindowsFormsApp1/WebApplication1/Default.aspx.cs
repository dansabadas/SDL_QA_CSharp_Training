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
        IArmy army = new Army();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
            {
                return;
            }

            ListOFCountries.DataTextField = "Name";
            ListOFCountries.DataValueField = "ID";
            ListOFCountries.DataSource = army.GetCountries();
            ListOFCountries.DataBind();
            ListOFCountries.Items.Insert(0, new ListItem { Text = "Select Country", Value = "0" });

            GridView1.DataSource = army.RetrueveSoldiers();
            GridView1.DataBind();

        }
        
        

        protected void IncrementButton_Click(object sender, EventArgs e)
        {
            IncrementButton.Text = "I was pressed";
            int clicks = 0;
            if (Session["ClickIncrement"] != null)
            {
                clicks = (int)Session["ClickIncrement"];

            }
            TextBox1.Text = (++clicks).ToString();
            Session["ClickIncrement"] = clicks;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ViewStateButton.Text = "I was pressed";
            int clicks = 0;
            if (ViewState["ClickIncrement"] != null)
            {
                clicks = (int)ViewState["ClickIncrement"];

            }
            TextBox2.Text = (++clicks).ToString();
            ViewState["ClickIncrement"] = clicks;
        }


        protected void HidePanelButton_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }

            ListBox1.Items.Add(new ListItem { Value = "10", Text = "10" });
        }

        protected void Filter_Click(object sender, EventArgs e)
        {
            if (ListOFCountries.SelectedItem.Value != 0.ToString())
            {
                var reportSoldiers = army.GetSoldiersByCountry
                (
                army.RetrueveSoldiers(),
                army.GetCountries()[Int32.Parse(ListOFCountries.SelectedItem.Value) - 1]
                );

                GridView1.DataSource = reportSoldiers;
                GridView1.DataBind();
            }
            else
            {
                GridView1.DataSource = army.RetrueveSoldiers();
                GridView1.DataBind();
            }
            

            
        }
    }
}