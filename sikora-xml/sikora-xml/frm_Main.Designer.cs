
namespace sikora_xml
{
	partial class frm_Main
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
			this.dataGrid = new System.Windows.Forms.DataGridView();
			this.btn_open = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_sort = new System.Windows.Forms.Button();
			this.btn_select = new System.Windows.Forms.Button();
			this.btn_exit = new System.Windows.Forms.Button();
			this.btn_info = new System.Windows.Forms.Button();
			this.btn_new = new System.Windows.Forms.Button();
			this.btn_clear = new System.Windows.Forms.Button();
			this.btn_web = new System.Windows.Forms.Button();
			this.addNew = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_titul = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.txt_prijmeni = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.txt_jmeno = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txt_vydavatel = new System.Windows.Forms.TextBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.txt_vydano = new System.Windows.Forms.TextBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.txt_pocetStran = new System.Windows.Forms.TextBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_confirm = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.addNew.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(198, 12);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(757, 282);
			this.dataGrid.TabIndex = 0;
			this.dataGrid.TabStop = false;
			// 
			// btn_open
			// 
			this.btn_open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_open.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_open.Image = ((System.Drawing.Image)(resources.GetObject("btn_open.Image")));
			this.btn_open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_open.Location = new System.Drawing.Point(307, 300);
			this.btn_open.Name = "btn_open";
			this.btn_open.Size = new System.Drawing.Size(103, 42);
			this.btn_open.TabIndex = 2;
			this.btn_open.Text = "Otevřít";
			this.btn_open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_open.UseVisualStyleBackColor = false;
			this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_save.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
			this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_save.Location = new System.Drawing.Point(416, 300);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(103, 42);
			this.btn_save.TabIndex = 3;
			this.btn_save.Text = "Uložit";
			this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(10, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 282);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// btn_sort
			// 
			this.btn_sort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_sort.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sort.Image = ((System.Drawing.Image)(resources.GetObject("btn_sort.Image")));
			this.btn_sort.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_sort.Location = new System.Drawing.Point(525, 300);
			this.btn_sort.Name = "btn_sort";
			this.btn_sort.Size = new System.Drawing.Size(103, 42);
			this.btn_sort.TabIndex = 4;
			this.btn_sort.Text = "Setřídit";
			this.btn_sort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_sort.UseVisualStyleBackColor = false;
			this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
			// 
			// btn_select
			// 
			this.btn_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_select.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_select.Image = ((System.Drawing.Image)(resources.GetObject("btn_select.Image")));
			this.btn_select.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_select.Location = new System.Drawing.Point(634, 300);
			this.btn_select.Name = "btn_select";
			this.btn_select.Size = new System.Drawing.Size(103, 42);
			this.btn_select.TabIndex = 5;
			this.btn_select.Text = "Vybrat";
			this.btn_select.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_select.UseVisualStyleBackColor = false;
			this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
			// 
			// btn_exit
			// 
			this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_exit.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_exit.Image")));
			this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_exit.Location = new System.Drawing.Point(852, 300);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(103, 42);
			this.btn_exit.TabIndex = 7;
			this.btn_exit.Text = "Ukončit";
			this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_exit.UseVisualStyleBackColor = false;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// btn_info
			// 
			this.btn_info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_info.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_info.Image = ((System.Drawing.Image)(resources.GetObject("btn_info.Image")));
			this.btn_info.Location = new System.Drawing.Point(10, 300);
			this.btn_info.Name = "btn_info";
			this.btn_info.Size = new System.Drawing.Size(42, 42);
			this.btn_info.TabIndex = 8;
			this.btn_info.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_info.UseVisualStyleBackColor = false;
			this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
			// 
			// btn_new
			// 
			this.btn_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_new.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_new.Image = ((System.Drawing.Image)(resources.GetObject("btn_new.Image")));
			this.btn_new.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_new.Location = new System.Drawing.Point(198, 300);
			this.btn_new.Name = "btn_new";
			this.btn_new.Size = new System.Drawing.Size(103, 42);
			this.btn_new.TabIndex = 1;
			this.btn_new.Text = "Přidat";
			this.btn_new.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_new.UseVisualStyleBackColor = false;
			this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
			// 
			// btn_clear
			// 
			this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_clear.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_clear.Image = ((System.Drawing.Image)(resources.GetObject("btn_clear.Image")));
			this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_clear.Location = new System.Drawing.Point(743, 300);
			this.btn_clear.Name = "btn_clear";
			this.btn_clear.Size = new System.Drawing.Size(103, 42);
			this.btn_clear.TabIndex = 6;
			this.btn_clear.Text = "Vymazat";
			this.btn_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_clear.UseVisualStyleBackColor = false;
			this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
			// 
			// btn_web
			// 
			this.btn_web.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_web.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_web.Image = ((System.Drawing.Image)(resources.GetObject("btn_web.Image")));
			this.btn_web.Location = new System.Drawing.Point(143, 300);
			this.btn_web.Name = "btn_web";
			this.btn_web.Size = new System.Drawing.Size(49, 42);
			this.btn_web.TabIndex = 9;
			this.btn_web.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_web.UseVisualStyleBackColor = false;
			this.btn_web.Click += new System.EventHandler(this.btn_info_Click);
			// 
			// addNew
			// 
			this.addNew.Controls.Add(this.groupBox2);
			this.addNew.Controls.Add(this.groupBox3);
			this.addNew.Controls.Add(this.groupBox4);
			this.addNew.Controls.Add(this.groupBox5);
			this.addNew.Controls.Add(this.groupBox6);
			this.addNew.Controls.Add(this.groupBox7);
			this.addNew.Controls.Add(this.btn_cancel);
			this.addNew.Controls.Add(this.btn_confirm);
			this.addNew.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.addNew.Location = new System.Drawing.Point(961, 12);
			this.addNew.Name = "addNew";
			this.addNew.Size = new System.Drawing.Size(288, 282);
			this.addNew.TabIndex = 10;
			this.addNew.TabStop = false;
			this.addNew.Text = "Přidat novou knihu";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox2.Controls.Add(this.txt_titul);
			this.groupBox2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(6, 24);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(133, 58);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Titul";
			// 
			// txt_titul
			// 
			this.txt_titul.Location = new System.Drawing.Point(9, 22);
			this.txt_titul.Name = "txt_titul";
			this.txt_titul.Size = new System.Drawing.Size(114, 23);
			this.txt_titul.TabIndex = 1;
			this.txt_titul.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox3.Controls.Add(this.txt_prijmeni);
			this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(6, 152);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(133, 58);
			this.groupBox3.TabIndex = 12;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Příjmení autora";
			// 
			// txt_prijmeni
			// 
			this.txt_prijmeni.Location = new System.Drawing.Point(6, 22);
			this.txt_prijmeni.Name = "txt_prijmeni";
			this.txt_prijmeni.Size = new System.Drawing.Size(117, 23);
			this.txt_prijmeni.TabIndex = 3;
			this.txt_prijmeni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.groupBox4.Controls.Add(this.txt_jmeno);
			this.groupBox4.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(6, 88);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(133, 58);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Jméno autora";
			// 
			// txt_jmeno
			// 
			this.txt_jmeno.Location = new System.Drawing.Point(6, 22);
			this.txt_jmeno.Name = "txt_jmeno";
			this.txt_jmeno.Size = new System.Drawing.Size(117, 23);
			this.txt_jmeno.TabIndex = 2;
			this.txt_jmeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.groupBox5.Controls.Add(this.txt_vydavatel);
			this.groupBox5.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(145, 24);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(133, 58);
			this.groupBox5.TabIndex = 13;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Vydavatel";
			// 
			// txt_vydavatel
			// 
			this.txt_vydavatel.Location = new System.Drawing.Point(6, 22);
			this.txt_vydavatel.Name = "txt_vydavatel";
			this.txt_vydavatel.Size = new System.Drawing.Size(117, 23);
			this.txt_vydavatel.TabIndex = 4;
			this.txt_vydavatel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox6
			// 
			this.groupBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox6.Controls.Add(this.txt_vydano);
			this.groupBox6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(145, 88);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(133, 58);
			this.groupBox6.TabIndex = 14;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Rok vydání";
			// 
			// txt_vydano
			// 
			this.txt_vydano.Location = new System.Drawing.Point(6, 22);
			this.txt_vydano.Name = "txt_vydano";
			this.txt_vydano.Size = new System.Drawing.Size(117, 23);
			this.txt_vydano.TabIndex = 5;
			this.txt_vydano.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox7
			// 
			this.groupBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.groupBox7.Controls.Add(this.txt_pocetStran);
			this.groupBox7.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(145, 152);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(133, 58);
			this.groupBox7.TabIndex = 15;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Počet stran";
			// 
			// txt_pocetStran
			// 
			this.txt_pocetStran.Location = new System.Drawing.Point(6, 22);
			this.txt_pocetStran.MaxLength = 4;
			this.txt_pocetStran.Name = "txt_pocetStran";
			this.txt_pocetStran.Size = new System.Drawing.Size(117, 23);
			this.txt_pocetStran.TabIndex = 6;
			this.txt_pocetStran.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btn_cancel
			// 
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cancel.Location = new System.Drawing.Point(145, 216);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(133, 42);
			this.btn_cancel.TabIndex = 17;
			this.btn_cancel.Text = "Zrušit";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cancel.UseVisualStyleBackColor = false;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_confirm
			// 
			this.btn_confirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_confirm.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_confirm.Image = ((System.Drawing.Image)(resources.GetObject("btn_confirm.Image")));
			this.btn_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_confirm.Location = new System.Drawing.Point(6, 216);
			this.btn_confirm.Name = "btn_confirm";
			this.btn_confirm.Size = new System.Drawing.Size(133, 42);
			this.btn_confirm.TabIndex = 16;
			this.btn_confirm.Text = "Přidat";
			this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_confirm.UseVisualStyleBackColor = false;
			this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
			// 
			// frm_Main
			// 
			this.AcceptButton = this.btn_save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.CancelButton = this.btn_exit;
			this.ClientSize = new System.Drawing.Size(1258, 351);
			this.Controls.Add(this.addNew);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_clear);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.btn_select);
			this.Controls.Add(this.btn_sort);
			this.Controls.Add(this.btn_web);
			this.Controls.Add(this.btn_info);
			this.Controls.Add(this.btn_new);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.btn_open);
			this.Controls.Add(this.dataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frm_Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "KnihaDB";
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.addNew.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_open;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_sort;
		private System.Windows.Forms.Button btn_select;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Button btn_info;
		private System.Windows.Forms.Button btn_new;
		private System.Windows.Forms.Button btn_clear;
		private System.Windows.Forms.Button btn_web;
		private System.Windows.Forms.DataGridView dataGrid;
		private System.Windows.Forms.GroupBox addNew;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txt_titul;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txt_prijmeni;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.TextBox txt_jmeno;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.TextBox txt_vydavatel;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txt_vydano;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox txt_pocetStran;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_confirm;
	}
}

