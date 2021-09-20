using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ResumeProject
{
    public partial class Default : System.Web.UI.Page
    {
        ResumeDbEntities db = new ResumeDbEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            RptInformations.DataSource = db.About.ToList();
            RptInformations.DataBind();

            RptEducation.DataSource = db.About.ToList();
            RptEducation.DataBind();

            RptExperiments.DataSource = db.About.ToList();
            RptExperiments.DataBind();

            RptSkill.DataSource = db.Skills.ToList();
            RptSkill.DataBind();
            
        }
    }
}