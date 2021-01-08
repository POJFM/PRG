
namespace Bakalari_v2
{
	partial class Form1
	{
		/// <summary>
		/// Vyžaduje se proměnná návrháře.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Uvolněte všechny používané prostředky.
		/// </summary>
		/// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kód generovaný Návrhářem Windows Form

		/// <summary>
		/// Metoda vyžadovaná pro podporu Návrháře - neupravovat
		/// obsah této metody v editoru kódu.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_grades = new System.Windows.Forms.Button();
			this.btn_students = new System.Windows.Forms.Button();
			this.datagrid_grades = new System.Windows.Forms.DataGridView();
			this.datagrid_students = new System.Windows.Forms.DataGridView();
			this.btn_orderByGrade = new System.Windows.Forms.Button();
			this.btn_orderBySubject = new System.Windows.Forms.Button();
			this.btn_orderByStudent = new System.Windows.Forms.Button();
			this.btn_groupByStudent = new System.Windows.Forms.Button();
			this.lbl_empty = new System.Windows.Forms.Label();
			this.btn_MathOnly = new System.Windows.Forms.Button();
			this.btn_prgOnly = new System.Windows.Forms.Button();
			this.btn_cjlOnly = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_grades)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(40)))));
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btn_grades);
			this.panel1.Controls.Add(this.btn_students);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(163, 450);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Bakalari_v2.Properties.Resources.book;
			this.pictureBox1.Location = new System.Drawing.Point(37, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(75, 75);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(12, 90);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "BAKALARI V2";
			// 
			// btn_grades
			// 
			this.btn_grades.FlatAppearance.BorderSize = 0;
			this.btn_grades.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_grades.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_grades.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_grades.Location = new System.Drawing.Point(0, 237);
			this.btn_grades.Name = "btn_grades";
			this.btn_grades.Size = new System.Drawing.Size(160, 79);
			this.btn_grades.TabIndex = 2;
			this.btn_grades.Text = "GRADES";
			this.btn_grades.UseVisualStyleBackColor = true;
			this.btn_grades.Click += new System.EventHandler(this.btn_grades_Click);
			// 
			// btn_students
			// 
			this.btn_students.FlatAppearance.BorderSize = 0;
			this.btn_students.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btn_students.Font = new System.Drawing.Font("Bahnschrift", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.btn_students.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.btn_students.Location = new System.Drawing.Point(0, 159);
			this.btn_students.Name = "btn_students";
			this.btn_students.Size = new System.Drawing.Size(160, 79);
			this.btn_students.TabIndex = 1;
			this.btn_students.Text = "STUDENTS";
			this.btn_students.UseVisualStyleBackColor = true;
			this.btn_students.Click += new System.EventHandler(this.btn_students_Click);
			// 
			// datagrid_grades
			// 
			this.datagrid_grades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagrid_grades.Location = new System.Drawing.Point(166, 88);
			this.datagrid_grades.Name = "datagrid_grades";
			this.datagrid_grades.Size = new System.Drawing.Size(629, 350);
			this.datagrid_grades.TabIndex = 1;
			this.datagrid_grades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_grades_CellContentClick);
			// 
			// datagrid_students
			// 
			this.datagrid_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.datagrid_students.Location = new System.Drawing.Point(166, 88);
			this.datagrid_students.Name = "datagrid_students";
			this.datagrid_students.Size = new System.Drawing.Size(629, 350);
			this.datagrid_students.TabIndex = 2;
			// 
			// btn_orderByGrade
			// 
			this.btn_orderByGrade.Location = new System.Drawing.Point(169, 12);
			this.btn_orderByGrade.Name = "btn_orderByGrade";
			this.btn_orderByGrade.Size = new System.Drawing.Size(124, 23);
			this.btn_orderByGrade.TabIndex = 3;
			this.btn_orderByGrade.Text = "Order by Grade";
			this.btn_orderByGrade.UseVisualStyleBackColor = true;
			this.btn_orderByGrade.Click += new System.EventHandler(this.btn_gradesAvg_Click);
			// 
			// btn_orderBySubject
			// 
			this.btn_orderBySubject.Location = new System.Drawing.Point(169, 41);
			this.btn_orderBySubject.Name = "btn_orderBySubject";
			this.btn_orderBySubject.Size = new System.Drawing.Size(124, 23);
			this.btn_orderBySubject.TabIndex = 4;
			this.btn_orderBySubject.Text = "Order by Subject";
			this.btn_orderBySubject.UseVisualStyleBackColor = true;
			this.btn_orderBySubject.Click += new System.EventHandler(this.btn_orderBySubject_Click);
			// 
			// btn_orderByStudent
			// 
			this.btn_orderByStudent.Location = new System.Drawing.Point(299, 12);
			this.btn_orderByStudent.Name = "btn_orderByStudent";
			this.btn_orderByStudent.Size = new System.Drawing.Size(124, 23);
			this.btn_orderByStudent.TabIndex = 5;
			this.btn_orderByStudent.Text = "Order by Student";
			this.btn_orderByStudent.UseVisualStyleBackColor = true;
			this.btn_orderByStudent.Click += new System.EventHandler(this.btn_orderByStudent_Click);
			// 
			// btn_groupByStudent
			// 
			this.btn_groupByStudent.Location = new System.Drawing.Point(299, 41);
			this.btn_groupByStudent.Name = "btn_groupByStudent";
			this.btn_groupByStudent.Size = new System.Drawing.Size(124, 23);
			this.btn_groupByStudent.TabIndex = 6;
			this.btn_groupByStudent.Text = "Grades by Student";
			this.btn_groupByStudent.UseVisualStyleBackColor = true;
			this.btn_groupByStudent.Click += new System.EventHandler(this.btn_groupByStudent_Click);
			// 
			// lbl_empty
			// 
			this.lbl_empty.AutoSize = true;
			this.lbl_empty.Font = new System.Drawing.Font("Bahnschrift", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.lbl_empty.Location = new System.Drawing.Point(233, 197);
			this.lbl_empty.Name = "lbl_empty";
			this.lbl_empty.Size = new System.Drawing.Size(489, 41);
			this.lbl_empty.TabIndex = 7;
			this.lbl_empty.Text = "THERE IS NOTHING TO SHOW :(";
			// 
			// btn_MathOnly
			// 
			this.btn_MathOnly.Location = new System.Drawing.Point(429, 12);
			this.btn_MathOnly.Name = "btn_MathOnly";
			this.btn_MathOnly.Size = new System.Drawing.Size(124, 23);
			this.btn_MathOnly.TabIndex = 8;
			this.btn_MathOnly.Text = "MAT Only";
			this.btn_MathOnly.UseVisualStyleBackColor = true;
			this.btn_MathOnly.Click += new System.EventHandler(this.btn_MathOnly_Click);
			// 
			// btn_prgOnly
			// 
			this.btn_prgOnly.Location = new System.Drawing.Point(559, 41);
			this.btn_prgOnly.Name = "btn_prgOnly";
			this.btn_prgOnly.Size = new System.Drawing.Size(124, 23);
			this.btn_prgOnly.TabIndex = 9;
			this.btn_prgOnly.Text = "PRG Only";
			this.btn_prgOnly.UseVisualStyleBackColor = true;
			this.btn_prgOnly.Click += new System.EventHandler(this.btn_prgOnly_Click);
			// 
			// btn_cjlOnly
			// 
			this.btn_cjlOnly.Location = new System.Drawing.Point(429, 41);
			this.btn_cjlOnly.Name = "btn_cjlOnly";
			this.btn_cjlOnly.Size = new System.Drawing.Size(124, 23);
			this.btn_cjlOnly.TabIndex = 10;
			this.btn_cjlOnly.Text = "CJL Only";
			this.btn_cjlOnly.UseVisualStyleBackColor = true;
			this.btn_cjlOnly.Click += new System.EventHandler(this.btn_cjlOnly_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_cjlOnly);
			this.Controls.Add(this.btn_prgOnly);
			this.Controls.Add(this.btn_MathOnly);
			this.Controls.Add(this.lbl_empty);
			this.Controls.Add(this.btn_groupByStudent);
			this.Controls.Add(this.btn_orderByStudent);
			this.Controls.Add(this.btn_orderBySubject);
			this.Controls.Add(this.btn_orderByGrade);
			this.Controls.Add(this.datagrid_students);
			this.Controls.Add(this.datagrid_grades);
			this.Controls.Add(this.panel1);
			this.MaximumSize = new System.Drawing.Size(816, 489);
			this.MinimumSize = new System.Drawing.Size(816, 489);
			this.Name = "Form1";
			this.ShowIcon = false;
			this.Text = "home | Bakalari_v2";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_grades)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.datagrid_students)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_grades;
		private System.Windows.Forms.Button btn_students;
		private System.Windows.Forms.DataGridView datagrid_grades;
		private System.Windows.Forms.DataGridView datagrid_students;
		private System.Windows.Forms.Button btn_orderByGrade;
		private System.Windows.Forms.Button btn_orderBySubject;
		private System.Windows.Forms.Button btn_orderByStudent;
		private System.Windows.Forms.Button btn_groupByStudent;
		private System.Windows.Forms.Label lbl_empty;
		private System.Windows.Forms.Button btn_MathOnly;
		private System.Windows.Forms.Button btn_prgOnly;
		private System.Windows.Forms.Button btn_cjlOnly;
	}
}

