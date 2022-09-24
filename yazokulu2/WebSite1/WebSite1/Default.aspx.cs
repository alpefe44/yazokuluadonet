using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;
using System.Data.SqlClient;


public partial class _Default : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
	
		
	}

	protected void Button1_Click(object sender, EventArgs e)
	{
		EntOgrenci entOgrenci = new EntOgrenci();
		entOgrenci.ograd = TextBox1.Text;
		entOgrenci.ogrsoyad = TextBox2.Text;
		entOgrenci.ogrnumara = TextBox3.Text;
		entOgrenci.ogrsifre = TextBox4.Text;
		entOgrenci.ogrmail = TextBox5.Text;

		BLLOgrenci.OgrenciEkle(entOgrenci);
	}
}