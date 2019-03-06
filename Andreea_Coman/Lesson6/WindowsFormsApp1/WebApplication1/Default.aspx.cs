using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary1;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.IsPostBack)
                { return; }
            this.TraceEnabled = false; 
            Army army = new Army();

            var countries = army.GetCountries();
            DropDownList1.DataTextField = "Name";
            DropDownList1.DataValueField = "ID";
            DropDownList1.DataSource = countries;
            DropDownList1.DataBind();
            DropDownList1.Items.Insert(0, new ListItem("select coutry", ""));

            var report = army.GetFullReport();
            GridView1.DataSource = report;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "I was pressed";
            int MyClicks = 0;
           
            if (Session["MyClicks"] != null)
            {
                 MyClicks =(int) Session["MyClicks"];
                
            }
            this.Label1.Text = (++MyClicks).ToString();
            Session["MyClicks"] = MyClicks;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Button2.Text = "Stop pressing";
            int MyClicks = 0;
           
            if (ViewState["MyClicks"] != null)
            {
                MyClicks = (int)ViewState["MyClicks"];

            }
            this.Label2.Text = (++MyClicks).ToString();
            ViewState["MyClicks"] = MyClicks;
        }
      

        protected void Button4_Click(object sender, EventArgs e)
        {
            if (Panel1.Visible == true)
            {
                Panel1.Visible = false;  
                Panel2.Visible = true;
            }
            else
            {
                Panel1.Visible = true;
                Panel2.Visible = false;
            }
            this.ListBox1.Items.Add(new ListItem { Value = 10.ToString(), Text = 10.ToString() });
        }

        protected void ImageMap1_Click(object sender, ImageMapEventArgs e)
        {

        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Label4.Text = DropDownList1.SelectedItem.ToString();
            Army army = new Army();
            if (string.IsNullOrEmpty(DropDownList1.SelectedItem.Value))
            {
                var reportSoldiers1 = army.GetFullReport();
                GridView1.DataSource = reportSoldiers1;
                GridView1.DataBind(); 
                return;
            }
            int countryID = int.Parse(DropDownList1.SelectedItem.Value);
       
            var report = army.GetFullReport();
            var soldiersByCountry = report
                .Where(soldier => soldier.CountryID = countryID);
            GridView1.DataSource = report;
            GridView1.DataBind();
        }
    }
}