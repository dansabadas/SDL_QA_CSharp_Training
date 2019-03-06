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
    }
}