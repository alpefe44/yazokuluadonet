using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using DataAccesLayer;
using EntityLayer;
using System.ServiceModel.Channels;
using BusinessLogicLayer;

public partial class OgrenciGuncelle : System.Web.UI.Page
{

	int x;
	protected void Page_Load(object sender, EventArgs e)
	{

		x = Convert.ToInt32(Request.QueryString["ID"]);
		Response.Write(x);
		TextBox6.Text = x.ToString();
		TextBox6.Enabled = false;

		if (Page.IsPostBack == false)
		{
			List<EntOgrenci> list = BLLOgrenci.OgrenciDetay(x);

			TextBox1.Text = list[0].ograd.ToString();
			TextBox2.Text = list[0].ogrsoyad.ToString();
			TextBox3.Text = list[0].ogrnumara.ToString();
			TextBox4.Text = list[0].ogrsifre.ToString();
			TextBox5.Text = list[0].ogrmail.ToString();

		}


	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		EntOgrenci ogrenci = new EntOgrenci();

		ogrenci.ograd = TextBox1.Text;
		ogrenci.ogrsoyad = TextBox2.Text;
		ogrenci.ogrnumara = TextBox3.Text;
		ogrenci.ogrsifre = TextBox4.Text;
		ogrenci.ogrmail = TextBox5.Text;
		ogrenci.ogrid = x;

		BLLOgrenci.OgrenciGuncelle(ogrenci);
		Response.Redirect("OgrenciListe.aspx");
	}
}