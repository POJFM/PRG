using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bakalari_v2
{
	public class Grade
	{
		private int student_id;
		private string subject; //could've been enum mby
		private int grade_itself;

		public int Student_id { get => student_id; set => student_id = value; }
		public string Subject { get => subject; set => subject = value; }
		public int Grade_itself { get => grade_itself; set => grade_itself = value; }

		public Grade(int students_id, string subject, int grade)
		{
			this.Student_id = students_id;
			this.Subject = subject;
			this.Grade_itself = grade;
		}
		public void Print()
		{
			Console.WriteLine("student_id: ", this.Student_id.ToString());
			Console.WriteLine("Subject:  ", this.Subject.ToString());
			Console.WriteLine("student_second_name: ", this.Grade_itself.ToString());

		}
	}
}
