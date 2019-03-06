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

            IArmy army = new Army();
            var countries = army.GetCountries();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "Id";
            DropDownList1.DataSource = countries;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("Select Country", ""));

            var reportSoldiers = army.GetFullReport();
            GridView1.DataSource = reportSoldiers;
            GridView1.DataBind();
        }

            protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "I was pressed";
            int myClicks = 0;
            if (Session["MyClicks"] != null)
            {
                myClicks = (int)Session["MyClicks"];
            }

            this.Label1.Text = (++myClicks).ToString();
            Session["MyClicks"] = myClicks;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Button2.Text = "I was pressed";
            int myClicks = 0;
            if (ViewState["MyClicks"] != null)
            {
                myClicks = (int)ViewState["MyClicks"];
            }

            this.Label2.Text = (++myClicks).ToString();
            ViewState["MyClicks"] = myClicks;
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == true)
            {
                panel1.Visible = false;
                panel2.Visible = true;
            }
            else
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
            this.ListBox1.Items.Add(new ListItem { Value = 10.ToString(), Text = 10.ToString() });
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Label3.Text = DropDownList1.SelectedItem.Value;

            IArmy army = new Army();
            if (string.IsNullOrEmpty(DropDownList1.SelectedItem.Value))
            {
                var reportSoldiers1 = army.GetFullReport();
                GridView1.DataSource = reportSoldiers1;
                GridView1.DataBind();
                return;
            }
            int countryId = int.Parse(DropDownList1.SelectedItem.Value);
                      
            
            var reportSoldiers = army.GetFullReportByCountry(countryId);

            GridView1.DataSource = reportSoldiers;
            GridView1.DataBind();
        }

       
    }
}