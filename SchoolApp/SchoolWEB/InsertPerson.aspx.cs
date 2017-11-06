using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolEntities;
using SchoolBLL;

namespace SchoolWEB
{
    public partial class InsertPerson : System.Web.UI.Page
    {
        CPersonBLL personB = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CPerson per = new CPerson();
            per.LastName = txtLastName.Text;
            per.FirstName = txtFirstName.Text;
            per.HireDate = Convert.ToDateTime(txtHireDate.Text);
            per.EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);

            personB.InsertarPersonaBLL(per);
        }

        protected void lnkRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}