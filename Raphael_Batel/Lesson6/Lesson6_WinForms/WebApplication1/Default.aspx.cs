using ArmyLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                return;
            Army army = new Army();
            var countries = army.GetCountries();
            DropDownList1.DataTextField = nameof(Country.Name);
            DropDownList1.DataValueField = nameof(Country.Id);
            DropDownList1.DataSource = countries;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Select country", ""));
            //Debug.WriteLine("Debugging");

            var soldiers = army.GetReportChinaAndUSA();
            GridView1.DataSource = soldiers;
            GridView1.DataBind();
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "Oh yeah.";

            int myClicks = 0;
            if (Session["MyClicks"] != null)
            {
                myClicks = (int) Session["MyClicks"];
                myClicks++;
            }
            this.Label1.Text = myClicks.ToString();
            Session["MyClicks"] = myClicks;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Ouch, that hurt.";

            int myClicks = 0;
            if (ViewState["MyClicks"] != null)
            {
                myClicks = (int)ViewState["MyClicks"];
                myClicks++;
            }
            else
            {
                myClicks = 1;
            }
            this.Label2.Text = myClicks.ToString();
            ViewState["MyClicks"] = myClicks;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if(Panel1.Visible)
            {
                Panel1.Visible = false;
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }

            this.ListBox1.Items.Add(new ListItem("10", "10"));

        }

        protected void Button_SearchSoldiers_Click(object sender, EventArgs e)
        {
            Label3.Text = DropDownList1.SelectedValue;

            int countryId = int.Parse(DropDownList1.SelectedValue);

            IArmy army = new Army();
            var soldiers = army.GetReportChinaAndUSA();
            var soldiersByCountry = soldiers.Where(s => ((dynamic)s).CountryId == countryId).ToList();
            GridView1.DataSource = soldiersByCountry;
            GridView1.DataBind();

        }
    }
}