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



    }
}