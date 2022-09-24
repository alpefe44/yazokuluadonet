using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using EntityLayer;
using DataAccesLayer;
using BusinessLogicLayer;
public partial class OgrenciListe : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		List<EntOgrenci> ogrenci = BLLOgrenci.OgrenciListele();
		Repeater1.DataSource = ogrenci;
		Repeater1.DataBind();
	}
}