
namespace sikora_xml
{
	partial class frm_Result
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Result));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btn_cancel = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.dataGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(10, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(182, 282);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 13;
			this.pictureBox1.TabStop = false;
			// 
			// btn_cancel
			// 
			this.btn_cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(205)))), ((int)(((byte)(254)))));
			this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_cancel.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
			this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_cancel.Location = new System.Drawing.Point(863, 60);
			this.btn_cancel.Name = "btn_cancel";
			this.btn_cancel.Size = new System.Drawing.Size(103, 42);
			this.btn_cancel.TabIndex = 18;
			this.btn_cancel.Text = "Zavřít";
			this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_cancel.UseVisualStyleBackColor = false;
			this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
			// 
			// btn_save
			// 
			this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_save.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
			this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_save.Location = new System.Drawing.Point(863, 12);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(103, 42);
			this.btn_save.TabIndex = 14;
			this.btn_save.Text = "Uložit";
			this.btn_save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_save.UseVisualStyleBackColor = false;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// dataGrid
			// 
			this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGrid.Location = new System.Drawing.Point(209, 12);
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.Size = new System.Drawing.Size(648, 282);
			this.dataGrid.TabIndex = 10;
			this.dataGrid.TabStop = false;
			// 
			// frm_Result
			// 
			this.AcceptButton = this.btn_save;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.CancelButton = this.btn_cancel;
			this.ClientSize = new System.Drawing.Size(977, 307);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btn_cancel);
			this.Controls.Add(this.btn_save);
			this.Controls.Add(this.dataGrid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Result";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Výsledek";
			this.Load += new System.EventHandler(this.frm_Result_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btn_cancel;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.DataGridView dataGrid;
	}
}