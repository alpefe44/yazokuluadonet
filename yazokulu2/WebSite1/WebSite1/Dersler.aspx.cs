using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntityLayer;
using DataAccesLayer;

public partial class Dersler : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		if (Page.IsPostBack == false)
		{
			List<EntDers> list = BLLDers.DersListele();
			DropDownList1.DataSource = list;
			DropDownList1.DataTextField = "dersad";
			DropDownList1.DataValueField = "dersid";
			DropDownList1.DataBind();
		}


	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		//TextBox1.Text = DropDownList1.SelectedValue.ToString();
		
		EntBasvuru entBasvuru = new EntBasvuru();
		entBasvuru.ogrid = int.Parse(TextBox1.Text);
		entBasvuru.dersid = int.Parse(DropDownList1.SelectedValue.ToString());
		BLLDers.TalepEkle(entBasvuru);

	}
}