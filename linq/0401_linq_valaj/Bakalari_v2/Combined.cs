using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari_v2
{
	class Combined
	{
		private int student_id;
		private string student_fname;
		private string student_sname;

		private string subject;
		private int grade;

		public int Student_id { get => student_id; set => student_id = value; }
		public string Student_fname { get => student_fname; set => student_fname = value; }
		public string Student_sname { get => student_sname; set => student_sname = value; }
		public string Subject { get => subject; set => subject = value; }
		public int Grade { get => grade; set => grade = value; }
		
		public Combined(int id, string fname, string sname, string subject, int grade)
		{
			this.Student_id = id;
			this.Student_fname = fname;
			this.Student_sname = sname;
			this.Subject = subject;
			this.Grade = grade;
		}
	}
}
