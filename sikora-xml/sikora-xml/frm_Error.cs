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
	public partial class frm_Error : Form
	{
		public frm_Error()
		{
			InitializeComponent();
		}

		public void Init(string e, Exception x)
		{
			errorMSG.Text = e;
			error.Text = x.ToString();
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
