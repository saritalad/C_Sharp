using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace SChemaFirstApproach
{
    public partial class _Default : Page
    {
        mydbEntities db;
        protected void Page_Load(object sender, EventArgs e)
        {
            db = new mydbEntities();
            GridView1.DataSource = db.employees.ToList();
            GridView1.DataBind();

        }
    }
}