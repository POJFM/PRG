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
	public partial class frm_Result : Form
	{
		public List<Kniha> data = new List<Kniha>();
		public frm_Result()
		{
			InitializeComponent();
		}

		private void frm_Result_Load(object sender, EventArgs e)
		{
			dataGrid.DataSource = data;
		}

		private void btn_save_Click(object sender, EventArgs e)
		{
			Program.SaveXML(data);
			this.Close();
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
