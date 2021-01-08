using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari_v2
{
	public class Student
	{
		private int id;
		private string student_fname;
		private string student_sname;
		private string student_email;
		private string student_class; //yeah.

		public int Id { get => id; set => id = value; }
		public string Student_fname { get => student_fname; set => student_fname = value; }
		public string Student_sname { get => student_sname; set => student_sname = value; }
		public string Student_email { get => student_email; set => student_email = value; }
		public string Student_class { get => student_class; set => student_class = value; }

		public Student(int id, string fname, string sname, string email, string classroom)
		{
			this.Id = id;
			this.Student_fname = fname;
			this.Student_sname = sname;
			this.Student_email = email;
			this.Student_class = classroom;
		}

		public void Print()
		{
			Console.WriteLine("student_id: ", this.id.ToString());
			Console.WriteLine("student_first_name: ", this.Student_fname);
			Console.WriteLine("student_second_name: ", this.Student_sname);
			Console.WriteLine("student_email: ", this.Student_email);
			Console.WriteLine("student_class: ", this.Student_class);
		}
	}
}
