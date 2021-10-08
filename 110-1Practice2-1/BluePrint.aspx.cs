using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1Practice2_1
{
    public partial class BluePrint : System.Web.UI.Page
    {
        public class man {
            public string s_ID;
            public float f_Hei;
            public float f_Wei;
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            man o_Man = new man();
            o_Man.s_ID = "A123456789";
            o_Man.f_Hei = 178.5f;
            o_Man.f_Wei = 72.8f;

            Response.Write("s_ID=" + o_Man.s_ID + "," + 
                "f_Hei=" + o_Man.f_Hei.ToString() + "," +
                "f_Wei=" + o_Man.f_Wei.ToString());
        }
    }
}