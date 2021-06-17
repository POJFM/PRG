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
	public partial class frm_Select : Form
	{
		public frm_Select()
		{
			InitializeComponent();
			SelectType();
			poleObsahuje.SelectedIndex = 0;
			poleVetsiMensi.SelectedIndex = 0;
		}

		private void optObsahuje_CheckedChanged(object sender, EventArgs e)
		{
			SelectType();
		}

		private void optVetsiMensi_CheckedChanged(object sender, EventArgs e)
		{
			SelectType();
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			List<Kniha> vysledek = new List<Kniha>();
			if (optObsahuje.Checked == true) // select podle toho co pole obsahuje
			{
				try
				{
					string input = inputObsahuje.Text;
					switch (poleObsahuje.SelectedIndex)
					{
						case 0:
							foreach (var x in from kniha in Program.knihy
											  where kniha.Titul == input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						case 1:
							foreach (var x in from kniha in Program.knihy
											  where kniha.AutorJ == input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						case 2:
							foreach (var x in from kniha in Program.knihy
											  where kniha.AutorP == input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						case 3:
							foreach (var x in from kniha in Program.knihy
											  where kniha.Vydavatel == input
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						case 4:
							foreach (var x in from kniha in Program.knihy
											  where kniha.Vydano == int.Parse(input)
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						case 5:
							foreach (var x in from kniha in Program.knihy
											  where kniha.PocetStran == int.Parse(input)
											  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
							{
								vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
							}
							Result(vysledek);
							break;
						default:
							Program.ErrorDialog("Vyberte pole");
							break;
					}
				}
				catch (Exception x) { Program.Error("Vyplňte všechny paramtery.", x); }
			}
			else // select podle vetsi/mensi nez pole
			{
				try
				{
					int input = int.Parse(inputVetsiMensi.Text);
					if (vetsi.Checked == true)
					{
						switch (poleVetsiMensi.SelectedIndex)
						{
							case 0:
								foreach (var x in from kniha in Program.knihy
												  where kniha.Vydano > input
												  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
								{
									vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
								}
								Result(vysledek);
								break;
							case 1:
								foreach (var x in from kniha in Program.knihy
												  where kniha.PocetStran > input
												  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
								{
									vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
								}
								Result(vysledek);
								break;
							default:
								Program.ErrorDialog("Vyberte pole");
								break;
						}
					}
					else
					{
						switch (poleVetsiMensi.SelectedIndex)
						{
							case 0:
								foreach (var x in from kniha in Program.knihy
												  where kniha.Vydano < input
												  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
								{
									vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
								}
								Result(vysledek);
								break;
							case 1:
								foreach (var x in from kniha in Program.knihy
												  where kniha.PocetStran < input
												  select new { kniha.Titul, kniha.AutorJ, kniha.AutorP, kniha.Vydavatel, kniha.Vydano, kniha.PocetStran })
								{
									vysledek.Add(new Kniha(x.Titul, x.AutorJ, x.AutorP, x.Vydavatel, x.Vydano, x.PocetStran));
								}
								Result(vysledek);
								break;
							default:
								Program.ErrorDialog("Vyberte pole");
								break;
						}
					}
				}
				catch (Exception x) { Program.Error("Vyplňte všechny paramtery.", x); }
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void SelectType()
		{
			if (optObsahuje.Checked == true)
			{
				groupBox1.Enabled = true;
				groupBox2.Enabled = false;
			}
			else
			{
				groupBox1.Enabled = false;
				groupBox2.Enabled = true;
			}
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
