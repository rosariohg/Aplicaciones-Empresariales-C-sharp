﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SchoolEntities;
using SchoolBLL;

namespace SchoolWEB
{
    public partial class UpdatePerson : System.Web.UI.Page
    {
        CPersonBLL personB = new CPersonBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CPerson per = personB.MostrarPersonaBLL((int)Session["PersonID"]);
                txtPersonID.Text = per.PersonID.ToString();
                txtLastName.Text = per.LastName;
                txtFirstName.Text = per.FirstName;
                txtHireDate.Text = per.HireDate.ToString();
                txtEnrollmentDate.Text = per.EnrollmentDate.ToString();
            }
            
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            CPerson per = new CPerson();
            per.PersonID = Convert.ToInt32(txtPersonID.Text);
            per.LastName = txtLastName.Text;
            per.FirstName = txtFirstName.Text;
            per.HireDate = Convert.ToDateTime(txtHireDate.Text);
            per.EnrollmentDate = Convert.ToDateTime(txtEnrollmentDate.Text);

            System.Diagnostics.Debug.WriteLine("PERSONA --- " + per.PersonID + " ");
            System.Diagnostics.Debug.WriteLine("PERSONA --- " + per.LastName + " ");
            personB.ModificarPersonaBLL(per);
        }

        protected void lnkRegresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}