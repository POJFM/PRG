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
	public partial class frm_Sort : Form
	{
		public frm_Sort()
		{
			InitializeComponent();
			setriditPodle.SelectedIndex = 0;
			vzestupne.Checked = true;
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			List<Kniha> vysledek = new List<Kniha>();
			if (sestupne.Checked == true)
			{
				switch (setriditPodle.SelectedIndex)
				{
					case 0:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					case 1:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					case 2:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					case 3:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					case 4:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					case 5:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).Reverse().ToList();
						Result(vysledek);
						break;
					default:
						Program.ErrorDialog("Vyberte pole");
						break;
				}
			}
			else
			{
				switch (setriditPodle.SelectedIndex)
				{
					case 0:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					case 1:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					case 2:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					case 3:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					case 4:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					case 5:
						vysledek = Program.knihy.OrderBy(a => a.Titul).Select(a => a).ToList();
						Result(vysledek);
						break;
					default:
						Program.ErrorDialog("Vyberte pole");
						break;
				}
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Result(List<Kniha> vysledek)
		{
			frm_Result frmResult = new frm_Result();
			this.Hide();
			frmResult.data = vysledek;
			frmResult.ShowDialog();
			this.Close();
		}
	}
}
