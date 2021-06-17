using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace sikora_xml
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frm_Main());
		}

		public static List<Kniha> knihy = new List<Kniha>();
		public static XmlWriterSettings settings = new XmlWriterSettings();

		public static void Error(string e, Exception x)
		{
			//MessageBox.Show(e, "Ooopsie, stala se chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			frm_Error frmError = new frm_Error();
			frmError.Show();
			frmError.Init(e, x);
		}

		public static void ErrorDialog(string e)
		{
			MessageBox.Show(e, "Ooopsie, stala se chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		public static void SaveXML(List<Kniha> data)
		{
			SaveFileDialog fileDialog = new SaveFileDialog();
			fileDialog.Title = "Uložit XML soubor";
			fileDialog.Filter = "XML soubor|*.xml|Všechny soubory|*.*";
			fileDialog.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;

			if (fileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					using (XmlWriter w = XmlWriter.Create(fileDialog.FileName, settings))
					{
						w.WriteStartDocument();
						w.WriteStartElement("knihy");
						data.ForEach(s =>
						{
							w.WriteStartElement("kniha");
							w.WriteAttributeString("titul", s.Titul);
							w.WriteAttributeString("jmeno", s.AutorJ);
							w.WriteAttributeString("prijmeni", s.AutorP);
							w.WriteAttributeString("vydavatel", s.Vydavatel);
							w.WriteAttributeString("vydano", s.Vydano.ToString());
							w.WriteAttributeString("pocetstran", s.PocetStran.ToString());
							w.WriteEndElement();
						});
						w.WriteEndElement();
						w.WriteEndDocument();
						w.Flush();
					}
				}
				catch (Exception x)
				{
					Error("Stala se chyba při ukládání souboru.", x);
				}
			}
		}
	}
}
