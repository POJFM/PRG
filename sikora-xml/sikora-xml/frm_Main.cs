using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sikora_xml
{
	public partial class frm_Main : Form
	{

		/*
		 * přidat tisk výsledků do pdf??? export dat do pdf, csv, json atd...
		 * později i import z dalších formátů
		 * potom i spojování souborů, pokud více souborů -> jak je spojit
		 * DODĚLAT ABOUT PROGRAMU
		 * DODĚLAT SELECT (ASPOŇ 2 KRITÉRIA - více kritérií?)
		 */

		//static frm_Main frm; // nutné pro přístup k DataGridView ve statické metodě RefreshData()

		public frm_Main()
		{
			InitializeComponent();
			addNew.Visible = false;
			this.Size = new Size(993, 390);
			//frm = this;
		}

		private void btn_info_Click(object sender, EventArgs e)
		{
			Form frmAbout = new frm_About();
			frmAbout.ShowDialog();
		}

		private void btn_web_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.fsikora.com");
		}

		#region pridat novou knihu
		private void btn_new_Click(object sender, EventArgs e)
		{
			/*Form frmNew = new frm_New();
			frmNew.ShowDialog();*/
			addNew.Visible = true;
			this.Size = new Size(1274, 390);
			this.AcceptButton = btn_confirm;
			this.CancelButton = btn_cancel;
		}

		private void btn_confirm_Click(object sender, EventArgs e)
		{
			try
			{
				Program.knihy.Add(new Kniha(txt_titul.Text, txt_jmeno.Text, txt_prijmeni.Text, txt_vydavatel.Text, int.Parse(txt_vydano.Text), int.Parse(txt_pocetStran.Text)));
				var bindingList = new BindingList<Kniha>(Program.knihy);
				BindingSource bindingSource = new BindingSource(bindingList, null);
				dataGrid.DataSource = bindingSource;
				clearTxt();
			}
			catch (Exception x)
			{
				Program.Error("Parametry špatně zadány, nebo chybí.", x);
			}
		}

		private void btn_cancel_Click(object sender, EventArgs e)
		{
			clearTxt();
			addNew.Visible = false;
			this.Size = new Size(993, 390);
			this.AcceptButton = btn_save;
			this.CancelButton = btn_exit;
		}

		private void clearTxt()
		{
			txt_titul.Text = "";
			txt_jmeno.Text = "";
			txt_prijmeni.Text = "";
			txt_vydavatel.Text = "";
			txt_vydano.Text = "";
			txt_pocetStran.Text = "";
		}
		#endregion

		// otevření XML souboru
		private void btn_open_Click(object sender, EventArgs e)
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			fileDialog.Title = "Otevřít XML soubor";
			fileDialog.Filter = "XML soubor|*.xml|Všechny soubory|*.*";
			fileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ClearDataGrid();
					using (XmlReader r = XmlReader.Create(fileDialog.FileName))
					{
						while (r.Read())
						{
							if (r.NodeType == XmlNodeType.Element)
							{
								if (r.Name == "kniha")
								{
									try
									{
										Program.knihy.Add(new Kniha(r.GetAttribute(0), r.GetAttribute(1), r.GetAttribute(2), r.GetAttribute(3), int.Parse(r.GetAttribute(4)), int.Parse(r.GetAttribute(5))));
									}
									catch (Exception x)
									{
										Program.Error("Špatný syntax souboru.", x);
									}
								}
							}
						}
					}
				}
				catch (Exception x)
				{
					Program.Error("Chyba při otvírání souboru.", x);
				}
			}
			RefreshData();
		}

		// uložení XML souboru
		private void btn_save_Click(object sender, EventArgs e)
		{
			Program.SaveXML(Program.knihy);
		}

		private void btn_sort_Click(object sender, EventArgs e)
		{
			Form frmSort = new frm_Sort();
			frmSort.Show();
		}

		private void btn_select_Click(object sender, EventArgs e)
		{
			Form frmSelect = new frm_Select();
			frmSelect.Show();
		}

		private void btn_clear_Click(object sender, EventArgs e)
		{
			// vymazat jen jednu entry nebo celý list
			/* TODO:
			 * zeptat se jestli smazat i soubor, pokud je nějaký otevřený
			 * jestli není co smazat (soubor ani data v tabulce), tak messagebox
			 * mby lišta s právě otevřeným souborem a cestou k němu i s ikonkama hihihi
			 */
			ClearDataGrid();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void RefreshData()
		{
			dataGrid.DataSource = Program.knihy;
		}

		private void ClearDataGrid()
		{
			Program.knihy.Clear();
			dataGrid.DataSource = null;
		}
	}
}
