
namespace sikora_xml
{
	partial class frm_Select
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Select));
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.optVetsiMensi = new System.Windows.Forms.RadioButton();
			this.optObsahuje = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.poleObsahuje = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.poleVetsiMensi = new System.Windows.Forms.ComboBox();
			this.vetsi = new System.Windows.Forms.RadioButton();
			this.mensi = new System.Windows.Forms.RadioButton();
			this.inputObsahuje = new System.Windows.Forms.TextBox();
			this.inputVetsiMensi = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_confirm = new System.Windows.Forms.Button();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.groupBox3.Controls.Add(this.optVetsiMensi);
			this.groupBox3.Controls.Add(this.optObsahuje);
			this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(506, 58);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Typ výběru";
			// 
			// optVetsiMensi
			// 
			this.optVetsiMensi.AutoSize = true;
			this.optVetsiMensi.Location = new System.Drawing.Point(262, 22);
			this.optVetsiMensi.Name = "optVetsiMensi";
			this.optVetsiMensi.Size = new System.Drawing.Size(130, 19);
			this.optVetsiMensi.TabIndex = 1;
			this.optVetsiMensi.Text = "Vetší/menší než";
			this.optVetsiMensi.UseVisualStyleBackColor = true;
			this.optVetsiMensi.CheckedChanged += new System.EventHandler(this.optVetsiMensi_CheckedChanged);
			// 
			// optObsahuje
			// 
			this.optObsahuje.AutoSize = true;
			this.optObsahuje.Checked = true;
			this.optObsahuje.Location = new System.Drawing.Point(6, 22);
			this.optObsahuje.Name = "optObsahuje";
			this.optObsahuje.Size = new System.Drawing.Size(116, 19);
			this.optObsahuje.TabIndex = 0;
			this.optObsahuje.TabStop = true;
			this.optObsahuje.Text = "Pole se rovná";
			this.optObsahuje.UseVisualStyleBackColor = true;
			this.optObsahuje.CheckedChanged += new System.EventHandler(this.optObsahuje_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.poleObsahuje);
			this.groupBox1.Controls.Add(this.inputObsahuje);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 76);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 111);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Pole se rovná";
			// 
			// poleObsahuje
			// 
			this.poleObsahuje.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.poleObsahuje.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.poleObsahuje.FormattingEnabled = true;
			this.poleObsahuje.Items.AddRange(new object[] {
            "Titul",
            "Jméno autora",
            "Příjmení autora",
            "Vydavatel",
            "Vydání",
            "Počet stran"});
			this.poleObsahuje.Location = new System.Drawing.Point(6, 22);
			this.poleObsahuje.Name = "poleObsahuje";
			this.poleObsahuje.Size = new System.Drawing.Size(238, 23);
			this.poleObsahuje.TabIndex = 0;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox2.Controls.Add(this.inputVetsiMensi);
			this.groupBox2.Controls.Add(this.mensi);
			this.groupBox2.Controls.Add(this.vetsi);
			this.groupBox2.Controls.Add(this.poleVetsiMensi);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(268, 76);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(250, 111);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Větší/menší než";
			// 
			// poleVetsiMensi
			// 
			this.poleVetsiMensi.FormattingEnabled = true;
			this.poleVetsiMensi.Items.AddRange(new object[] {
            "Vydání",
            "Počet stran"});
			this.poleVetsiMensi.Location = new System.Drawing.Point(6, 22);
			this.poleVetsiMensi.Name = "poleVetsiMensi";
			this.poleVetsiMensi.Size = new System.Drawing.Size(238, 23);
			this.poleVetsiMensi.TabIndex = 0;
			// 
			// vetsi
			// 
			this.vetsi.AutoSize = true;
			this.vetsi.Checked = true;
			this.vetsi.Location = new System.Drawing.Point(6, 51);
			this.vetsi.Name = "vetsi";
			this.vetsi.Size = new System.Drawing.Size(88, 19);
			this.vetsi.TabIndex = 1;
			this.vetsi.TabStop = true;
			this.vetsi.Text = "Větší než";
			this.vetsi.UseVisualStyleBackColor = true;
			// 
			// mensi
			// 
			this.mensi.AutoSize = true;
			this.mensi.Location = new System.Drawing.Point(100, 51);
			this.mensi.Name = "mensi";
			this.mensi.Size = new System.Drawing.Size(88, 19);
			this.mensi.TabIndex = 2;
			this.mensi.Text = "Menší než";
			this.mensi.UseVisualStyleBackColor = true;
			// 
			// inputObsahuje
			// 
			this.inputObsahuje.Location = new System.Drawing.Point(6, 77);
			this.inputObsahuje.Name = "inputObsahuje";
			this.inputObsahuje.Size = new System.Drawing.Size(238, 23);
			this.inputObsahuje.TabIndex = 1;
			// 
			// inputVetsiMensi
			// 
			this.inputVetsiMensi.Location = new System.Drawing.Point(6, 77);
			this.inputVetsiMensi.Name = "inputVetsiMensi";
			this.inputVetsiMensi.Size = new System.Drawing.Size(238, 23);
			this.inputVetsiMensi.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "Se rovná:";
			// 
			// btn_confirm
			// 
			this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_confirm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_confirm.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirm.Image")));
			this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_confirm.Location = new System.Drawing.Point(159, 193);
			this.btn_confirm.Name = "btn_confirm";
			this.btn_confirm.Size = new System.Drawing.Size(103, 42);
			this.btn_confirm.TabIndex = 2;
			this.btn_confirm.Text = "Vybrat";
			this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_confirm.UseVisualStyleBackColor = false;
			this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
			// 
			// btn_cancel
			// 
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cancel.Location = new System.Drawing.Point(268, 193);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(103, 42);
			this.btn_cancel.TabIndex = 3;
			this.btn_cancel.Text = "Zavřít";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cancel.UseVisualStyleBackColor = false;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// frm_Select
			// 
			this.AcceptButton = this.btn_confirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(531, 243);
			this.Controls.Add(this.btn_confirm);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Select";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Vybrat";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton optVetsiMensi;
		private System.Windows.Forms.RadioButton optObsahuje;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox poleObsahuje;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inputObsahuje;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox inputVetsiMensi;
		private System.Windows.Forms.RadioButton mensi;
		private System.Windows.Forms.RadioButton vetsi;
		private System.Windows.Forms.ComboBox poleVetsiMensi;
		private System.Windows.Forms.Button btn_confirm;
		private System.Windows.Forms.Button btn_cancel;
	}
}