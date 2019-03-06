using System;
using System.Collections.Generic;
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

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.Button1.Text = "i was pressed";
            this.Label1.Text = 1.ToString();
            int myClicks = 0;
            if ((Session["myClicks"]) != null)
            {
                myClicks = (int)Session["myClicks"];             
            }
            this.Label1.Text = (++myClicks).ToString();
            Session["myClicks"] = myClicks;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            this.Button2.Text = "i was pressed";
            this.Label2.Text = 1.ToString();
            int myClicks = 0;
            if ((ViewState["myClicks"]) != null)
            {
                myClicks = (int)ViewState["myClicks"];
            }
            this.Label2.Text = (++myClicks).ToString();
            ViewState["myClicks"] = myClicks;
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

            ListBox1.Items.Add(new ListItem("text"));
        }
    }
}