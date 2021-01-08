using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
*/

namespace Bakalari_v2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		// Set local Linked Lists
		public List<Student> studentList = new List<Student>();
		public List<Grade> gradesList = new List<Grade>();


		public void Form1_Load(object sender, EventArgs e)
		{
			#region Lists

			// Fill those bad bois up
			studentList.Add(new Student(1, "Jan", "Novák", "novakj@pojfm.cz", "A205"));
			studentList.Add(new Student(2, "Adam", "Novotný", "novotnya@pojfm.cz", "A205"));
			studentList.Add(new Student(3, "Karel", "Ondrka", "ondrkak@pojfm.cz", "A205"));

			// Each student will  have three grades 
			// Student 1
			gradesList.Add(new Grade(1, "MAT", 2));
			gradesList.Add(new Grade(1, "MAT", 3));
			gradesList.Add(new Grade(1, "MAT", 5));
			gradesList.Add(new Grade(1, "CJL", 1));
			gradesList.Add(new Grade(1, "PRG", 2));
			// Student 2
			gradesList.Add(new Grade(2, "MAT", 5));
			gradesList.Add(new Grade(2, "CJL", 2));
			gradesList.Add(new Grade(2, "MAT", 1));
			// Student 3 
			gradesList.Add(new Grade(3, "CJL", 4));
			gradesList.Add(new Grade(3, "PRG", 4));
			gradesList.Add(new Grade(3, "PRG", 4));
			#endregion

			datagrid_students.Visible = false;
			datagrid_grades.Visible = false;
			btn_orderByGrade.Visible = false;
			btn_orderByStudent.Visible = false;
			btn_orderBySubject.Visible = false;
			btn_groupByStudent.Visible = false;
			btn_cjlOnly.Visible = false;
			btn_prgOnly.Visible = false;
			btn_MathOnly.Visible = false;
			lbl_empty.Visible = true;


			#region MongoDB Connection a destruktualizace - NEFUNKČNÍ
			// Nějak se nemůžu dostat k destruktualizaci na List<Student> z idkCoToJe<BsonDocument>, takze to udelam
			// po staru a vykaslu se na DB connection.
			/*-------------------------------------
			try
			{
				// Connect to MongoDB database bcuz I can
				MongoClient dbClient = new MongoClient("mongodb+srv://admin:notreallyapassword@cluster1.jm77o.mongodb.net/NiceTry:)))?retryWrites=true&w=majority");
				var db = dbClient.GetDatabase("Bakalari_v2");

				// Get collections (stored in JSON/BSON format)
				var grades_collection = db.GetCollection<Student>("Grades");
				var students_collection = db.GetCollection<BsonDocument>("Students");

				#region I should've create funct for that
				// Get all data from both collections
				// Should be called in asynchronous method (await - async) but I have no time for that
				var allStudentsObject = students_collection.Find(new BsonDocument());
				// DESCTRUCTURIZE
				foreach (BsonDocument student in allStudentsObject.ToEnumerable()) 
				{
					// Deseralize
					var student1 = BsonSerializer.Deserialize<Student>(student);
					//student1.Print();
					//studentList.Add(new Student(student["_id"].ToInt32(), student["student_fname"].ToString(), student["student_sname"].ToString(), student["student_emai"].ToString(), student["student_class"].ToString()));
					
				}	
				#endregion
			}
			catch (Exception) //this is duplicate bcuz in MongoDriver already is a try catch block, but imma leave this there
			{
				Console.WriteLine("Something went wrong!");
			}
			--------------------------------------------- */
			#endregion
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void btn_students_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_students);
			var bindingList = new BindingList<Student>(studentList);
			var source = new BindingSource(bindingList, null);

			datagrid_students.DataSource = source;
			
			datagrid_students.Visible = true;
			datagrid_grades.Visible = false;
			btn_orderByGrade.Visible = false;
			btn_orderByStudent.Visible = false;
			btn_orderBySubject.Visible = false;
			btn_groupByStudent.Visible = false;
			btn_MathOnly.Visible = false;
			btn_cjlOnly.Visible = false;
			btn_prgOnly.Visible = false;
			lbl_empty.Visible = false;
		}

		private void btn_grades_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var bindingList = new BindingList<Grade>(gradesList);
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;

			datagrid_students.Visible = false;
			datagrid_grades.Visible = true;
			btn_orderByGrade.Visible = true;
			btn_orderByStudent.Visible = true;
			btn_orderBySubject.Visible = true;
			btn_groupByStudent.Visible = true;
			btn_MathOnly.Visible = true;
			btn_cjlOnly.Visible = true;
			btn_prgOnly.Visible = true;
			lbl_empty.Visible = false;
		}

		private void datagrid_grades_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
		
		// V případě, že to stihnu dodělat a udělám i update metody
		public void clearDataGrid(DataGridView grid)
		{
			grid.DataSource = null;
		}

		private void btn_gradesAvg_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);

			var result = from g in gradesList
						 orderby g.Grade_itself
						 select g ;

			

			var bindingList = new BindingList<Grade>(result.ToList());
			var source = new BindingSource(bindingList, null); 

			datagrid_grades.DataSource = source;
			
		}

		private void btn_orderBySubject_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var result = from g in gradesList
						 orderby g.Subject
						 select g;

			var bindingList = new BindingList<Grade>(result.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;
		}

		private void btn_orderByStudent_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var result = from g in gradesList
						 orderby g.Student_id
						 select g;

			var bindingList = new BindingList<Grade>(result.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;
		}

		private void btn_groupByStudent_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);

			var result = from g in gradesList
						 join s in studentList
						 on g.Student_id equals s.Id
						 select new
						 {
							 Student_id = s.Id,
							 Student_fname = s.Student_fname,
							 Student_sname = s.Student_sname,
							 Subject = g.Subject,
							 Grade = g.Grade_itself
						 };

			List<Combined> tempList = new List<Combined>();
			foreach(var elmt in result)
			{
				tempList.Add(new Combined(elmt.Student_id, elmt.Student_fname, elmt.Student_sname, elmt.Subject, elmt.Grade));
			}

			var bindingList = new BindingList<Combined>(tempList.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;
		}

		private void btn_avgGrades_Click(object sender, EventArgs e)
		{

		}

		private void btn_MathOnly_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var result = from g in gradesList
						 where g.Subject == "MAT"
						 select new
						 {
							 Id = g.Student_id,
							 Subject = g.Subject,
							 Grade = g.Grade_itself
						 };
			List<Grade> tempList = new List<Grade>();
			foreach(var elmnt in result)
			{
				tempList.Add(new Grade(elmnt.Id, elmnt.Subject, elmnt.Grade));
			}
			var bindingList = new BindingList<Grade>(tempList.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;

		}

		private void btn_cjlOnly_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var result = from g in gradesList
						 where g.Subject == "CJL"
						 select new
						 {
							 Id = g.Student_id,
							 Subject = g.Subject,
							 Grade = g.Grade_itself
						 };
			List<Grade> tempList = new List<Grade>();
			foreach (var elmnt in result)
			{
				tempList.Add(new Grade(elmnt.Id, elmnt.Subject, elmnt.Grade));
			}
			var bindingList = new BindingList<Grade>(tempList.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;
		}

		private void btn_prgOnly_Click(object sender, EventArgs e)
		{
			clearDataGrid(datagrid_grades);
			var result = from g in gradesList
						 where g.Subject == "PRG"
						 select new
						 {
							 Id = g.Student_id,
							 Subject = g.Subject,
							 Grade = g.Grade_itself
						 };
			List<Grade> tempList = new List<Grade>();
			foreach (var elmnt in result)
			{
				tempList.Add(new Grade(elmnt.Id, elmnt.Subject, elmnt.Grade));
			}
			var bindingList = new BindingList<Grade>(tempList.ToList());
			var source = new BindingSource(bindingList, null);

			datagrid_grades.DataSource = source;
		}
	}

	

}

