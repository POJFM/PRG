using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sikora_xml
{
	public partial class frm_New : Form
	{
		public frm_New()
		{
			InitializeComponent();
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			try
			{
				Program.knihy.Add(new Kniha(txt_titul.Text, txt_jmeno.Text, txt_prijmeni.Text, txt_vydavatel.Text, int.Parse(txt_vydano.Text), int.Parse(txt_pocetStran.Text)));
				//frm_Main.RefreshData();
				txt_titul.Text = "";
				txt_jmeno.Text = "";
				txt_prijmeni.Text = "";
				txt_vydavatel.Text = "";
				txt_vydano.Text = "";
				txt_pocetStran.Text = "";
			}
			catch (Exception x)
			{
				Program.Error("Parametry špatně zadány, nebo chybí.", x);
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
