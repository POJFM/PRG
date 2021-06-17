
namespace sikora_xml
{
	partial class frm_Sort
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Sort));
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_confirm = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.sestupne = new System.Windows.Forms.RadioButton();
			this.vzestupne = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.setriditPodle = new System.Windows.Forms.ComboBox();
			this.groupBox3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_cancel
			// 
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cancel.Location = new System.Drawing.Point(159, 140);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(103, 42);
			this.btn_cancel.TabIndex = 4;
			this.btn_cancel.Text = "Zavřít";
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
			this.btn_confirm.Location = new System.Drawing.Point(12, 140);
			this.btn_confirm.Name = "btn_confirm";
			this.btn_confirm.Size = new System.Drawing.Size(103, 42);
			this.btn_confirm.TabIndex = 3;
			this.btn_confirm.Text = "Setřídit";
			this.btn_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_confirm.UseVisualStyleBackColor = false;
			this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.groupBox3.Controls.Add(this.sestupne);
			this.groupBox3.Controls.Add(this.vzestupne);
			this.groupBox3.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(12, 76);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(250, 58);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Pořadí";
			// 
			// sestupne
			// 
			this.sestupne.AutoSize = true;
			this.sestupne.Location = new System.Drawing.Point(147, 22);
			this.sestupne.Name = "sestupne";
			this.sestupne.Size = new System.Drawing.Size(81, 19);
			this.sestupne.TabIndex = 1;
			this.sestupne.TabStop = true;
			this.sestupne.Text = "Sestupně";
			this.sestupne.UseVisualStyleBackColor = true;
			// 
			// vzestupne
			// 
			this.vzestupne.AutoSize = true;
			this.vzestupne.Location = new System.Drawing.Point(15, 22);
			this.vzestupne.Name = "vzestupne";
			this.vzestupne.Size = new System.Drawing.Size(88, 19);
			this.vzestupne.TabIndex = 0;
			this.vzestupne.TabStop = true;
			this.vzestupne.Text = "Vzestupně";
			this.vzestupne.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.groupBox1.Controls.Add(this.setriditPodle);
			this.groupBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(250, 58);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Setřídit podle";
			// 
			// setriditPodle
			// 
			this.setriditPodle.FormattingEnabled = true;
			this.setriditPodle.Items.AddRange(new object[] {
            "Titul",
            "Jméno autora",
            "Příjmení autora",
            "Vydavatel",
            "Vydání",
            "Počet stran"});
			this.setriditPodle.Location = new System.Drawing.Point(6, 22);
			this.setriditPodle.Name = "setriditPodle";
			this.setriditPodle.Size = new System.Drawing.Size(238, 23);
			this.setriditPodle.TabIndex = 0;
			// 
			// frm_Order
			// 
			this.AcceptButton = this.btn_confirm;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(273, 191);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_confirm);
			this.Controls.Add(this.btn_cancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Order";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Setřídit";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_confirm;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton sestupne;
		private System.Windows.Forms.RadioButton vzestupne;
		private System.Windows.Forms.ComboBox setriditPodle;
	}
}